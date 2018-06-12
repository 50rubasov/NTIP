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
    public partial class RectangleControl : UserControl
    {
        private double _a;
        private double _b;
        private bool _readOnly;
        public RectangleControl()
        {
            InitializeComponent();
        }

        public Areas.Rectangle rectangle
        {
            get
            {
                return new Areas.Rectangle(Convert.ToDouble(numericUpDownA.Text), Convert.ToDouble(numericUpDownB.Text));
            }

            set
            {
                if (_readOnly)
                {
                    _a = value.A;
                    _b = value.B;
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
