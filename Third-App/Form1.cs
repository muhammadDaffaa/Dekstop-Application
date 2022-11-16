using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using LiveCharts.Defaults;
using LiveCharts.Configurations;

namespace Third_App
{
    public partial class Form1 : Form
    {

        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private ModbusClient modbusClient;
        private string dataSensor;
        private ChartValues<MeasureModel> chartValues;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            timer1.Start();

            //Chart
            var mapper = Mappers.Xy<MeasureModel>()
                          .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                          .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            //the ChartValues property will store our values array
            ChartValues = new ChartValues<MeasureModel>();
            cartesianChart1.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Values = ChartValues,
                    PointGeometrySize = 8,
                    StrokeThickness = 2
                }
            };
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            SetAxisLimits(DateTime.Now);

            //The next code simulates data changes every 500 ms
            Timer = new Timer
            {
                Interval = 1000
            };
            Timer.Tick += TimerOnTick;
            //R = new Random();
            Timer.Start();
        }

        public ChartValues<MeasureModel> ChartValues { get => chartValues; set => chartValues = value; }
        public Timer Timer { get; set; }
        //public Random R { get; set; }

        private void SetAxisLimits(DateTime now)
        {
            cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            var now = DateTime.Now;

            ChartValues.Add(new MeasureModel
            {
                DateTime = now,
                //Value = R.Next(0, 10)
                Value = Convert.ToDouble(dataSensor)
            });

            SetAxisLimits(now);

            //lets only use the last 30 values
            if (ChartValues.Count > 30) ChartValues.RemoveAt(0);
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

            modbusClient = new ModbusClient("192.168.18.178", 502);    //Ip-Address and Port of Modbus-TCP-Server
            modbusClient.Connect();                                                    //Connect to Server
                                                                                       //modbusClient.WriteMultipleCoils(4, new bool[] { true, true, true, true, true, true, true, true, true, true });    //Write Coils starting with Address 5
                                                                                       //bool[] readCoils = modbusClient.ReadCoils(9, 10);                        //Read 10 Coils from Server, starting with address 10
            int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 5);    //Read 10 Holding Registers from Server, starting with Address 1

            Console.WriteLine(readHoldingRegisters);
            // Console Output
            // for (int i = 0; i < readCoils.Length; i++)
            //    Console.WriteLine("Value of Coil " + (9 + i + 1) + " " + readCoils[i].ToString())


            for (int i = 0; i < readHoldingRegisters.Length; i++)
            {

                //Console.WriteLine(ConvertDW2Float((short)readHoldingRegisters[1], (short)readHoldingRegisters[0]));
                dataSensor = ConvertDW2Float((short)readHoldingRegisters[1], (short)readHoldingRegisters[0]).ToString();
                label2.Text = ConvertDW2Float((short)readHoldingRegisters[1], (short)readHoldingRegisters[0]).ToString();
                Console.WriteLine(dataSensor);
            }

            //Disconnect from Server
            modbusClient.Disconnect();
        }


        //Program Orang
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ComModbusTCP();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
