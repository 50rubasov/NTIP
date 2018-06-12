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
    /// <summary>
    /// форма для добавления новой фигуры
    /// </summary>
    public partial class CreateFigure : Form
    {
        public CreateFigure()
        {
            InitializeComponent();
            MakeElementsInvisible();
        }

        public IFigure figure { get; private set; }

        /// <summary>
        /// Метод скрывающий элементы формы
        /// </summary>
        private void MakeElementsInvisible()
        {
           // numericUpDownA.Visible = false;
           // numericUpDownB.Visible = false;
           // numericUpDownH.Visible = false;
            numericUpDownR.Visible = false;

           // labelA.Visible = false;
           // labelB.Visible = false;
           // labelH.Visible = false;
            labelR.Visible = false;

            triangleControl1.Visible = false;
            AddFigureButton.Visible = false;
            CloseButton.Visible = false;
            RandomValueButton.Visible = false;
        }
        /// <summary>
        /// Метод для отчистки элементов
        /// </summary>
        private void ClearElements()
        {
            //numericUpDownA.Value = 0;
            //numericUpDownB.Value = 0;
            //numericUpDownH.Value = 0;
            //numericUpDownR.Value = 0;


            Close();
        }
        /// <summary>
        /// метод вызываемый для добавления одного из трех фигур
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Добавить?",
                "Подтвердите",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (SelectFigureBox.SelectedIndex == 0)
                {
                    figure = triangleControl1.triangle;
                }
                else if (SelectFigureBox.SelectedIndex == 1)
                {
                    figure = rectangleControl1.rectangle;
                }
                //else
                //{
                //    figure = new Circle(Convert.ToDouble(numericUpDownR.Text));
                //}
            }
                ClearElements();
        }
        /// <summary>
        /// Обработчик события на изменение данных
        /// в ComboBox
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void SelectFigureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeElementsInvisible();
            AddFigureButton.Visible = true;
            CloseButton.Visible = true;
#if DEBUG
            RandomValueButton.Visible = true;
#endif
            if (SelectFigureBox.SelectedIndex == 0)
            {
                triangleControl1.Visible = true;
            }
            if (SelectFigureBox.SelectedIndex == 2)
            {
                numericUpDownR.Visible = true;
                labelR.Visible = true;
            }
            //if (SelectFigureBox.SelectedIndex == 1)
            //{
            //    numericUpDownA.Visible = true;
            //    numericUpDownB.Visible = true;
            //    labelA.Visible = true;
            //    labelB.Visible = true;
            //}
        }
        /// <summary>
        /// Метод вызываемый при закрытии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            MakeElementsInvisible();
            ClearElements();
            SelectFigureBox.SelectedIndex = -1;
        }
        /// <summary>
        /// Метод вызываемый для генерации случайных значений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomValueButton_Click(object sender, EventArgs e)
        {
#if DEBUG
            Random random = new Random();
            if (SelectFigureBox.SelectedIndex == 0)
            {
                //numericUpDownA.Value = random.Next(100);
                //numericUpDownH.Value = random.Next(100);
            }
            else if (SelectFigureBox.SelectedIndex == 1)
            {
                //numericUpDownA.Value = random.Next(100);
              //  numericUpDownB.Value = random.Next(100);
            }
            else
            {
                numericUpDownR.Value = random.Next(100);
            }
#endif
        }
        /// <summary>
        /// Метод вызываемый для отчистки формы при закрытии на крестик
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateFigure_FormClosed(object sender, FormClosedEventArgs e)
        {
            MakeElementsInvisible();
            ClearElements();
            SelectFigureBox.SelectedIndex = -1;
            AddFigureButton.Visible = false;
            CloseButton.Visible = false;
            RandomValueButton.Visible = false;
        }
        /// <summary>
        /// Метод вызываемый для удаления объекта при исчезновении формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFigureBox_VisibleChanged(object sender, EventArgs e)
        {
            figure = null;
        }
    }

}
