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
                if (value == null) return;
                numericUpDownA.Text = Convert.ToString(value.A);
                numericUpDownB.Text = Convert.ToString(value.B);
            }
        }

        public bool ReadOnly
        {
            get { return ReadOnly; }
            set
            {
                numericUpDownA.ReadOnly = value;
                numericUpDownB.ReadOnly = value;
                
                
            }

        }

    }
}
