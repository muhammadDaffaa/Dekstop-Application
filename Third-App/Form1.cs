using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Third_App
{
    public partial class Form1 : Form
    {

        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private ModbusClient modbusClient;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            timer1.Start();
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColors.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColors.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];


            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTopBar.BackColor = color;
                    panelLogo.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.DarkOrchid;
                    previousButton.ForeColor = Color.Transparent;
                    previousButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            // label2.Text = "Dashboard";
        }

        private void buttonReporting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            // label2.Text = "Reporting";

        }

        private void buttonLogging_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            //label2.Text = "Logging";

        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            //label2.Text = "Setting";

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void ComModbusTCP()
        {
            modbusClient = new ModbusClient("192.168.1.6", 502);    //Ip-Address and Port of Modbus-TCP-Server
            modbusClient.Connect();                                                    //Connect to Server
            //modbusClient.WriteMultipleCoils(4, new bool[] { true, true, true, true, true, true, true, true, true, true });    //Write Coils starting with Address 5
            //bool[] readCoils = modbusClient.ReadCoils(9, 10);                        //Read 10 Coils from Server, starting with address 10
            int[] readInputRegisters = modbusClient.ReadInputRegisters(0, 1);    //Read 10 Holding Registers from Server, starting with Address 1

            // Console Output
            // for (int i = 0; i < readCoils.Length; i++)
            //    Console.WriteLine("Value of Coil " + (9 + i + 1) + " " + readCoils[i].ToString());

            for (int i = 0; i < readInputRegisters.Length; i++)
            {
                Console.WriteLine("Value of Input Register " + (i + 1) + " " + readInputRegisters[i].ToString());
                label2.Text = readInputRegisters[i].ToString();
            }

            //Disconnect from Server
            modbusClient.Disconnect();                                                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ComModbusTCP();
        }
    }
}
