using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Circle:IFigure
    {
        double R;
        public Circle(double R)
        {
            this.R = R;
        }

        public double Area()
        {
            {
                return 2*Math.PI*R;
            }
        }
    }
}
