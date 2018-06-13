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
    public partial class CircleControl : UserControl
    {
        private bool _readOnly;
        public CircleControl()
        {
            InitializeComponent();
        }
        public Circle circle
        {
            get
            {
                return new Circle(Convert.ToDouble(numericUpDownR.Text));
            }

            set
            {
                if (value == null) return;
                numericUpDownR.Text = Convert.ToString(value.R);
            }
        }

        public bool ReadOnly
        {
            get { return ReadOnly; }
            set
            {
                numericUpDownR.ReadOnly = value;

            }

        }
    }
}
