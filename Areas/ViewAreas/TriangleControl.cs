using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Areas;

namespace ViewAreas
{
    public partial class TriangleControl : UserControl
    {
        private double _a;
        private double _h;
        private bool _readOnly;

        public TriangleControl()
        {
            InitializeComponent();
        }

        public Triangle triangle
        {
            get
            {
               return new Triangle(Convert.ToDouble(numericUpDownA.Text), Convert.ToDouble(numericUpDownH.Text));
            }

            set
            {
                if (_readOnly)
                {
                    _a = value.A;
                    _h = value.H;
                }
            }
        }

        public bool ReadOnly
        {
            get { return _readOnly; }
            set { _readOnly = value; }
        }

    }
}
