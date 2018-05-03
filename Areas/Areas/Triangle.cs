using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Triangle:IFigure
    {
        double a, b, c;
        //конструктор

       public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Area()
        {
            {
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }

    }
}
