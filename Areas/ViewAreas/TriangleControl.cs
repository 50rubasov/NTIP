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
                if (value == null) return;
                numericUpDownA.Text = Convert.ToString(value.A);
                numericUpDownH.Text = Convert.ToString(value.H);
            }
        }

        public bool ReadOnly
        {
            get { return ReadOnly; }
            set
            {
                numericUpDownA.ReadOnly = value;
                numericUpDownH.ReadOnly = value;

            }

        }

    }
}
