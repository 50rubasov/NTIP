using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Areas;
namespace ViewAreas
{
    public partial class CreateFigure : Form
    {
        private BindingSource _figureBindingSource;

        public CreateFigure(BindingSource figureBindingSource)
        {
            InitializeComponent();
            _figureBindingSource = figureBindingSource;
            MakeElementsInvisible();
        }

        private void MakeElementsInvisible()
        {
            numericUpDownA.Visible = false;
            numericUpDownB.Visible = false;
            numericUpDownH.Visible = false;
            numericUpDownR.Visible = false;

            labelA.Visible = false;
            labelB.Visible = false;
            labelH.Visible = false;
            labelR.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Добавить?",
                "Подтвердите",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                IFigure figure;
                if (comboBox1.SelectedIndex == 0)
                {
                    figure = new Triangle(Convert.ToDouble(numericUpDownA.Text), Convert.ToDouble(numericUpDownH.Text));
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    figure = new Areas.Rectangle(Convert.ToDouble(numericUpDownA.Text), Convert.ToDouble(numericUpDownB.Text));
                }
                else
                {
                    figure = new Circle(Convert.ToDouble(numericUpDownR.Text));
                }
                _figureBindingSource.Add(figure);
            }
        }
        /// <summary>
        /// Обработчик события на изменение данных
        /// в ComboBox
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeElementsInvisible();
            button1.Visible = true;
            button2.Visible = true;
#if DEBUG
            button3.Visible = true;
#endif
            if (comboBox1.SelectedIndex == 0)
            {
                numericUpDownA.Visible = true;
                numericUpDownH.Visible = true;
                labelA.Visible = true;
                labelH.Visible = true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                numericUpDownR.Visible = true;
                labelR.Visible = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                numericUpDownA.Visible = true;
                numericUpDownB.Visible = true;
                labelA.Visible = true;
                labelB.Visible = true;
            }
        }
        /// <summary>
        /// Метод вызываемый при закрытии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
#if DEBUG
            Random random = new Random();
            decimal randomValue = random.Next(100);
            if (comboBox1.SelectedIndex == 0)
            {
                numericUpDownA.Value = randomValue;
                numericUpDownH.Value = randomValue;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                numericUpDownA.Value = randomValue;
                numericUpDownB.Value = randomValue;
            }
            else
            {
                numericUpDownR.Value = randomValue;
            }
#endif
        }
    }

}
