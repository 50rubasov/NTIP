using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Rectangle:IFigure
    {
        double a, b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
    public double Area()
        {
            return a * b;
        }
    }
}
