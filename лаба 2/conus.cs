using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2
{
    class Conus : Circle
    {
        

        private double h;
        public double H { get => h; set => h = value; }

        public Conus()
        {

        }

        public Conus(double h)
        {
            this.H = h; //переменная используемая в поле класса
        }


        public double GetSquareOfSideSurface()
        {
            return Pi * base.R * base.GetL(); //площадь боковой поверхности
        }

        public double GetVolume()
        {
            return (Pi * this.H * Math.Pow(this.R, 2)) / 3;
        }

        

        public double GetFullSquare()
        {
            return this.GetSquareOfSideSurface() + base.GetSquare(); //Площадь полной поверхости
        }

        public override string ToString()//вывод информации
        {
            return "\nРадиус Основы:" + this.R +
                   "\nОбъем:" + this.GetVolume() +
                   "\nПлощадь Полной Поверхности" + this.GetFullSquare();

        }

    }
}
