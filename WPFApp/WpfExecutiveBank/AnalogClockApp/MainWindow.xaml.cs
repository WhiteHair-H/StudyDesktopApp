using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AnalogClockApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        public Point Center { get; set; }
        public double Radius { get; set; }
        public int HourHand { get; set; }
        public int MinHand { get; set; }
        public int SecHand { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Initialized(object sender, EventArgs e)
        {
            SetClock();
            SetTimer();

        }

        private void SetTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0,0,10);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime curtime = DateTime.Now;

            CvsClock.Children.Clear();
            DrawClockFace();
            double radHr = (curtime.Hour % 12 + curtime.Minute / 60.0) * 30 * Math.PI / 180;
            double radMin = (curtime.Minute % 12 + curtime.Second / 60.0) * 6 * Math.PI / 180;
            double radSec = (curtime.Second % 12 + curtime.Millisecond /1000.0) * 6 * Math.PI / 180;
            DrawHands(radHr, radMin, radSec);
        }

        private void DrawHands(double radHr, double radMin, double radSec)
        {
            //시침
            DrawLine(HourHand * Math.Sin(radHr), -HourHand * Math.Cos(radHr),
                0, 0, Brushes.RoyalBlue, 8, new Thickness(Center.X, Center.Y, 0, 0));

            //분침
            DrawLine(MinHand * Math.Sin(radMin), -MinHand * Math.Cos(radMin),
                0, 0, Brushes.SkyBlue, 6, new Thickness(Center.X, Center.Y, 0, 0));

            //초침
            DrawLine(SecHand * Math.Sin(radSec), -SecHand * Math.Cos(radSec),
                0, 0, Brushes.OrangeRed, 3, new Thickness(Center.X, Center.Y, 0, 0));

            Ellipse core = new Ellipse();
            core.Margin = new Thickness(CvsClock.Width / 2 - 10, CvsClock.Height / 2 - 10, 0, 0);
            core.Stroke = Brushes.RoyalBlue;
            core.Fill = Brushes.RoyalBlue;
            core.Width = 16;
            core.Height = 16;
            CvsClock.Children.Add(core);

        }

        private void DrawLine(double x1, double y1, int x2, int y2, SolidColorBrush color , int thick , Thickness margin)
        {
            Line line = new Line();
            line.X1 = x1; 
            line.Y1 = y1; 
            line.X2 = x2; 
            line.Y2 = y2;
            line.Stroke = color;
            line.StrokeThickness = thick;
            line.Margin = margin;
            line.StrokeStartLineCap = PenLineCap.Triangle;
            CvsClock.Children.Add(line);

        }

        private void DrawClockFace()
        {
            ElsClock.Stroke = Brushes.LightSteelBlue;
            ElsClock.StrokeThickness = 30;
            CvsClock.Children.Add(ElsClock);
        }

        private void SetClock()
        {
            Center = new Point(CvsClock.Width / 2, CvsClock.Height / 2);
            Radius = CvsClock.Width / 2; // 시계 반지름
            HourHand = (int)(Radius * 0.45); // 시침 길이
            MinHand = (int)(Radius * 0.55); // 분침 길이
            SecHand = (int)(Radius * 0.65); // 초침 길이


        }
    }
}
