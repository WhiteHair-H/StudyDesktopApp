using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IoTSensorMonApp
{
    public partial class FrmMain : Form
    {
        private double xCount = 200; // 차트에 보이는 데이터 수


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // ComboBox 초기화

            foreach (var port in SerialPort.GetPortNames())
            {
                CboSerialPort.Items.Add(port);
            }
            CboSerialPort.Text = "Select Port";

            // IoT장비에서 받을 값의 범위
            PrbPhotoResister.Minimum = 0;
            PrbPhotoResister.Maximum = 1023;
            PrbPhotoResister.Value = 0;

            // 차트모양 초기화
            InitChartStyle();



            // BtnDisplay 초기화

            BtnDisplay.BackColor = Color.BlueViolet;
            BtnDisplay.ForeColor = Color.WhiteSmoke;
            BtnDisplay.Text = "NONE";
            BtnDisplay.Font = new Font("맑은 고딕", 14, FontStyle.Bold);
            LblConnectTime.Text = "Connection Time :";
            TxtSensorNum.TextAlign = HorizontalAlignment.Right;
            TxtSensorNum.Text = "0";
            BtnConnect.Enabled = BtnConnect.Enabled = false;


        }
        /// <summary>
        /// 차트 초기설정
        /// </summary>
        private void InitChartStyle()
        {
            
            ChtPhotoResistor.ChartAreas[0].BackColor = Color.Blue;
            ChtPhotoResistor.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResistor.ChartAreas[0].AxisX.Maximum = xCount;
            ChtPhotoResistor.ChartAreas[0].AxisX.Interval = xCount / 4; //간격
            ChtPhotoResistor.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResistor.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResistor.ChartAreas[0].BackColor = Color.Blue;
            ChtPhotoResistor.ChartAreas[0].AxisY.Minimum = 0;
            ChtPhotoResistor.ChartAreas[0].AxisY.Maximum = 1024;
            ChtPhotoResistor.ChartAreas[0].AxisY.Interval = xCount; //간격
            ChtPhotoResistor.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResistor.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResistor.ChartAreas[0].CursorX.AutoScroll = true;
            ChtPhotoResistor.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChtPhotoResistor.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ChtPhotoResistor.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            ChtPhotoResistor.Series.Clear();
            ChtPhotoResistor.Series.Add("PhotoValue");
            ChtPhotoResistor.Series[0].ChartType = SeriesChartType.Line;
            ChtPhotoResistor.Series[0].Color = Color.LightCoral;
            ChtPhotoResistor.Series[0].BorderWidth = 3;


            //범례 삭제
            if (ChtPhotoResistor.Legends.Count > 0)
            {
                for (int i = 0; i < ChtPhotoResistor.Legends.Count; i++)
                {
                    ChtPhotoResistor.Legends.RemoveAt(i);
                }
            }

            


        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //TODO 나중에 실제 작업시 작성
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            //TODO 나중에 실제 작업시 작성

        }

        private Timer timerSimul = new Timer();
        private Random randPhoto = new Random();
        private bool IsSimulation = false;
        private List<SensorData> sensors = new List<SensorData>(); // 차트 , 리스트박스 출력


        /// <summary>
        /// 시뮬레이션 시작
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuBeginSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            timerSimul.Enabled = true;
            timerSimul.Interval = 1000;
            timerSimul.Tick += TimerSimul_Tick;
            timerSimul.Start();
        }

        private void TimerSimul_Tick(object sender, EventArgs e)
        {
            int value = randPhoto.Next(1, 1023); // 1부터 1023까지 사이의 값
            ShowSensorValue(value.ToString());
                                                
        }
        /// <summary>
        /// 센서값 화면 출력 메서드
        /// </summary>
        /// <param name="value"></param>
        private void ShowSensorValue(string value)
        {
            int.TryParse(value, out int v);


            var currentTime = DateTime.Now;
            SensorData data = new SensorData(currentTime, v,IsSimulation);
            sensors.Add(data);


            // 센서값 갯수
            TxtSensorNum.Text = $"{sensors.Count}";
            // 프로그레스바 현재값 출력
            PrbPhotoResister.Value = v;
            // 리스트박스에 데이터 출력
            var item = $"{currentTime.ToString("yyyy-MM-dd HH:mm:ss")} \t {v}";
            LsbPhotoResistor.Items.Add(item);
            LsbPhotoResistor.SelectedIndex = LsbPhotoResistor.Items.Count - 1; // 스크롤처리

            // 차트에 데이터 출력
            ChtPhotoResistor.Series[0].Points.Add(v);


        }

        /// <summary>
        /// 시뮬레이션 끝
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuEndSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = false;
            timerSimul.Stop();
        }


        /// <summary>
        /// 종료버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (IsSimulation)
            {
                MessageBox.Show("시뮬레이션 멈춘후 프로그램을 종료하세요","종료",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Environment.Exit(0);

        }
    }
}
