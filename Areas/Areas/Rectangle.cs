using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Rectangle : IFigure
    {
        private double _a;
        private double _b;

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public double Area()
        {
            if ((A < 0) || (B < 0))
            {
                throw new Exception("Координаты должны быть больше нуля");
            }
            return A * B;
        }
    }
}
