using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2
{
    class Circle
    {
        private const double pi = 3.14;
        private double r;

        public static double Pi => pi;

        public double R { get => r; set => r = value; }

        public Circle()
        {

        }

        public Circle(double r)
        {
            //переменная используемая в поле класса
            this.R = r;
        }

        public double GetSquare()//площадь
        {
            return Pi * Math.Pow(this.R, 2);
        }

        public double GetL()//длина
        {
            return 2 * Pi * this.R;
        }

        public override string ToString()//вывод информации
        {
            return "\nРадиус:" + this.R +
                    "\nДлина:" + this.GetL() +
                    "\nПлощадь:" + this.GetSquare();
        }

    }
}