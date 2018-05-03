using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;
        //конструктор

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
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

        public double C
        {
            get { return _c; }
            set { _c = value; }
        }

        public double Area()
        {
            if ((A < 0) || (B < 0) || (C < 0))
            {
                throw new Exception("Координаты должны быть больше нуля");
            }
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
    }
}
