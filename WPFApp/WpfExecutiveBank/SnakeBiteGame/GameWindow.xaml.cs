using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SnakeBiteGame
{
    /// <summary>
    /// GameWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GameWindow : Window
    {
        Random rand = new Random();

        Ellipse[] snake = new Ellipse[30];
        Ellipse egg = new Ellipse();
        private int size = 12;
        private int visibleCount = 5;
        private string move = "";
        private int eaten = 0;
        DispatcherTimer playtimer = new DispatcherTimer();
        Stopwatch stopwatch = new Stopwatch();
        private bool startFlag = false;



        public GameWindow()
        {
            InitializeComponent();
        }
        private void Window_Initialized(object sender, EventArgs e)
        {
            InitSnake();
            InitEgg();

            playtimer.Interval = new TimeSpan(0, 0, 0, 0, 100); // 0.1초
            playtimer.Tick += Playtimer_Tick;
            playtimer.Start();
        }
        private void InitSnake()
        {
            int x = rand.Next(1, 500 / size) * size;
            int y = rand.Next(1, 400 / size) * size;

            for (int i = 0; i < 30; i++)
            {
                snake[i] = new Ellipse();
                snake[i].Width = snake[i].Height = size;
                if (i == 0)
                    snake[i].Fill = Brushes.Chocolate;
                else if (i % 5 == 0)
                    snake[i].Fill = Brushes.YellowGreen;
                else
                    snake[i].Fill = Brushes.Gold;
                    snake[i].Stroke = Brushes.Black;

                    CvsGame.Children.Add(snake[i]);
                
            }

            // 뱀길이를 5개, 나머지 화면에서 지움
            for (int i = visibleCount; i < 30; i++)
            {
                snake[i].Visibility = Visibility.Hidden;
            }
            CreateSnake(x, y);

        }

        private void CreateSnake(int x, int y)
        {
            for (int i = 0; i < visibleCount; i++)
            {
                snake[i].Tag = new Point(x, y + i * size);
                Canvas.SetLeft(snake[i], x);
                Canvas.SetTop(snake[i], y + i * size);
            }
        }

        private void InitEgg()
        {
            
        }


        private void Playtimer_Tick(object sender, EventArgs e)
        {
            if (move != "")
            {
                startFlag = true;

                for (int i = visibleCount; i >= 1 ; i--)
                {
                    Point p = (Point)snake[i - 1].Tag;
                    snake[i].Tag = new Point(p.X, p.Y);
                }


                //키보드 옮겼을 때 처리

                // 알을 먹었는지 체크

            }

            if (startFlag)
            {
                TimeSpan span = stopwatch.Elapsed;
                TxtTime.Text = $"Time = {span.Minutes} : {span.Seconds}: {span.Milliseconds / 10}";
                Draw_snake();


            }


        }

        private void Draw_snake()
        {
            for (int i = 0; i < visibleCount; i++)
            {
                Point p = (Point)snake[i].Tag;
                Canvas.SetLeft(snake[i], p.X);
                Canvas.SetTop(snake[i], p.Y);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (move == "")stopwatch.Start();


            // 키조작
        }

    }
}
