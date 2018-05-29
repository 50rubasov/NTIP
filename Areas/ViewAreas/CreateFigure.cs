using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  
namespace ViewAreas
{
    public partial class CreateFigure : Form
    {
        private BindingSource _figureBindingSource;
        public CreateFigure()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
        }

        private void FalseTextBoxes()
        {
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;
            maskedTextBox3.Visible = false;
            maskedTextBox4.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Добавить?",
                "Подтвердите",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _figureBindingSource.Add()
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
            ClearTextBoxes();
            FalseTextBoxes();

            if (comboBox1.SelectedItem == "Triangle")
            {
                maskedTextBox1.Visible = true;
                maskedTextBox3.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
            }
            if (comboBox1.SelectedItem == "Circle")
            {
                maskedTextBox4.Visible = true;
                label4.Visible = true;
            }
            if (comboBox1.SelectedItem == "Rectangle")
            {
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            ClearTextBoxes();
        }
    }
    
}
