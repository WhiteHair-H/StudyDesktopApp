using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfPracticeApp.BusinessLogic
{
    public class Car : Notifier
    {
        // public double Speed { get; set; } 아래와 같은 코드


       // 부가적인 처리가 있을 경우 사용함
       private double speed;
       public double Speed 
        { get { return speed; } 
          set 
            { 
                if ( value > 350)
                {
                    speed = 350;
                }
                else
                {
                    Speed = value;
                }
                speed = value;
                OnPropertyChanged("Speed"); // 속성값 변경된 것을 알려줌(프로그램에서)
            }
        }


        private Color mainColor;

        public Color MainColor
        {
            get { return mainColor; }
            set { OnPropertyChanged("MainColor");
            }
        }

        public Human Driver { get; set; }
    }

    public class Human
    {
        public string Name { get; set; }

        public bool HasDriveLicense { get; set; }
    }


}
