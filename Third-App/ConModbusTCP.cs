using EasyModbus;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_App
{
    public class ConModbusTCP
    {

        //Field
        public ModbusClient modbusClient;

        // Constructor
        public ConModbusTCP(string ipAddressModbus, int portModbus)
        {
            modbusClient = new ModbusClient(ipAddressModbus, portModbus);
        }

        //MODBUS TCP READ HOLDING REGISTER
        public void ModbusTCPReadHoldingRegisters(string dataSensor)
        {

            //Connect to Server
            modbusClient.Connect();

            int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 5);    //Read 10 Holding Registers from Server, starting with Address 1

            for (int i = 0; i < readHoldingRegisters.Length; i++)
            {
                VarGlobal.dataTemperatureSensor = dataSensor;
                dataSensor = ConvertDW2Float((short)readHoldingRegisters[1], (short)readHoldingRegisters[0]).ToString();
            }

            //Disconnect from Server
            modbusClient.Disconnect();

        }

        //Convert HexString to Float
        private double ConvertDW2Float(short int1, short int2)
        {

            byte[] intBytes1 = BitConverter.GetBytes(int1);
            if (BitConverter.IsLittleEndian) Array.Reverse(intBytes1);
            // byte[] result1 = intBytes1;
            byte[] intBytes2 = BitConverter.GetBytes(int2);
            if (BitConverter.IsLittleEndian) Array.Reverse(intBytes2);
            //byte[] result2 = intBytes2;
            byte[] _bytes = new byte[4];
            _bytes[0] = intBytes1[1];
            _bytes[1] = intBytes1[0];
            _bytes[2] = intBytes2[1];
            _bytes[3] = intBytes2[0];
            double _val = BitConverter.ToSingle(_bytes, 0);
            _val = Math.Round(_val, 3);

            return _val;
        }
    }
}