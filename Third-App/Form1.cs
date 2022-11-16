using EasyModbus;
using System;
using System.Drawing;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Configurations;

namespace Third_App
{
    public partial class Form1 : Form
    {

        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private string dataSensor;
        public string displayData;
        private ChartValues<MeasureModel> chartValues;
        public ChartValues<MeasureModel> ChartValues { get => chartValues; set => chartValues = value; }
        public Timer Timer { get; set; }
        //public Random R { get; set; }

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
                Value = Convert.ToDouble(VarGlobal.dataTemperatureSensor)
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

        private void ComModbusTCPSiemens()
        {

            ConModbusTCP modbusClient = new ConModbusTCP("192.168.18.178", 502);
            modbusClient.ModbusTCPReadHoldingRegisters(dataSensor);
            label2.Text = VarGlobal.dataTemperatureSensor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ComModbusTCPSiemens();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
