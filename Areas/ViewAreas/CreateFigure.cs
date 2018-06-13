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

        public IFigure figure
        {
            get
            {
                if (SelectFigureBox.SelectedIndex == 0)
                {
                    return triangleControl1.triangle;
                }

                else if (SelectFigureBox.SelectedIndex == 1)
                {
                    return rectangleControl1.rectangle;
                }

                else if (SelectFigureBox.SelectedIndex == 2)
                {
                    return circleControl1.circle;
                }
                else return null;

            }
            set
            {
                if (value is Triangle _triangle)
                {
                    triangleControl1.triangle = _triangle;
                    SelectFigureBox.SelectedIndex = 0;
                }

                if (value is Areas.Rectangle _rectangle)
                {
                    rectangleControl1.rectangle = _rectangle;
                    SelectFigureBox.SelectedIndex = 1;
                }

                if (value is Circle _circle)
                {
                    circleControl1.circle = _circle;
                    SelectFigureBox.SelectedIndex = 2;
                }
            }
        }

        public bool ReadOnly
        {
            set
            {
                triangleControl1.ReadOnly = value;
                rectangleControl1.ReadOnly = value;
                circleControl1.ReadOnly = value;
            }
        }


        public CreateFigure()
        {
            InitializeComponent();
            MakeElementsInvisible();
        }

        /// <summary>
        /// Метод скрывающий элементы формы
        /// </summary>
        private void MakeElementsInvisible()
        {

            triangleControl1.Visible = false;
            rectangleControl1.Visible = false;
            circleControl1.Visible = false;
            AddFigureButton.Visible = false;
            CloseButton.Visible = false;
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
            if (SelectFigureBox.SelectedIndex == 0)
            {
                triangleControl1.Visible = true;
            }
            if (SelectFigureBox.SelectedIndex == 1)
            {
                rectangleControl1.Visible = true;
            }
            if (SelectFigureBox.SelectedIndex == 2)
            {
                circleControl1.Visible = true;
            }
        }
    }

}
