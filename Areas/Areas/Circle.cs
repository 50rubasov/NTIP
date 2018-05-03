using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Circle : IFigure
    {
        private double _r;

        public Circle(double r)
        {
            R = r;
        }

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public double Area()
        {
            if (R < 0)
            {
                throw new Exception("Радиус должн быть больше нуля");
            }
            return 2 * Math.PI * R;
        }
    }
}
