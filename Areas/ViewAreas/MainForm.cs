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
using System.IO;
using System.Runtime.Serialization.Json;
using Rectangle = Areas.Rectangle;

namespace ViewAreas
{
    /// <summary>
    /// главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список фигур
        /// </summary>
        private List<IFigure> _figures;
        /// <summary>
        /// форма добавления новой фигуры
        /// </summary>
        private CreateFigure _createFigure;
        /// <summary>
        /// Сериализадия/дессериализация
        /// </summary>
        private DataContractJsonSerializer _serializer;

        public MainForm()
        {
            InitializeComponent();

            _createFigure = new CreateFigure();
            _figures = new List<IFigure>();

            figureBindingSource.DataSource = _figures;
            dataGridView1.DataSource = figureBindingSource;


            List<Type> knownTypeList = new List<Type>();

            knownTypeList.Add(typeof(Triangle));
            knownTypeList.Add(typeof(Areas.Rectangle));
            knownTypeList.Add(typeof(Circle));
            _serializer = new DataContractJsonSerializer(typeof(List<IFigure>), knownTypeList);

            DisableControls();
        }
        
        /// <summary>
        /// метод вызываемый для Добавления фигуры с базы данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddObject_Click(object sender, EventArgs e)
        {
            CreateFigure _createFigure = new CreateFigure()
            {
                ReadOnly = false
            };
            _createFigure.ShowDialog();
            if(_createFigure.DialogResult != DialogResult.OK) return;
            if (_createFigure.figure != null)
            {
                figureBindingSource.Add(_createFigure.figure);
            }
        }
        /// <summary>
        /// метод вызываемый для удаления фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteObject_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Удалить?",
                "Подтвердите",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dataGridView1.RowCount > 0)
                {
                    int index = dataGridView1.SelectedCells[0].RowIndex;
                    dataGridView1.Rows.RemoveAt(index);
                }
            }
        }
        /// <summary>
        /// метод вызываемый для открытия файла(дессериализации)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "Figures|*.fig";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Открытие отменено!",
                        "Открыть",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }

            if (result == DialogResult.OK)
            {
                try
                {
                    FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate);
                    List<IFigure> deserializeFigures = (List<IFigure>)_serializer.ReadObject(fileStream);
                    fileStream.Dispose();

                    figureBindingSource.Clear();

                    foreach (IFigure figure in deserializeFigures)
                    {
                        figureBindingSource.Add(figure);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        /// <summary>
        /// метод вызываемый для сохранения файла(сериализации)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Figures|*.fig";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Сохранение отменено!",
                        "Сохранить",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }

            if (result == DialogResult.OK)
            {
                try
                {
                    FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
                    _serializer.WriteObject(fileStream, _figures);
                    fileStream.Dispose();

                    MessageBox.Show("Файл сохранен. \r\nПуть:" + saveFileDialog1.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
#if DEBUG
        /// <summary>
        /// Метод для создания случайных фигур по кнопке ctrl+num0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    if (e.Control)
                    {
                        IFigure figure;
                        Random random = new Random();
                        double randomValue = random.Next(100);
                        int randomFigure = random.Next(3);

                        if (randomFigure == 0)
                        {
                            figure = new Triangle(randomValue, randomValue);
                        }
                        else if (randomFigure == 1)
                        {
                            figure = new Areas.Rectangle(randomValue, randomValue);
                        }
                        else
                        {
                            figure = new Circle(randomValue);
                        }
                        figureBindingSource.Add(figure);
                    }
                    break;
                default:
                   
                    break;
            } 
        }
#endif
        /// <summary>
        /// метод вызываемый для поиска фигур больше определенного значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_ValueChanged(object sender, EventArgs e)
        {
           
            List<int> indexes = new List<int>();

            for(int index = 0; index < dataGridView1.RowCount; index++)
            {
                dataGridView1.Rows[index].Visible = true;
            }

            for (int count = 0; count < dataGridView1.RowCount; count++)
            {
                double value = Convert.ToDouble(dataGridView1.Rows[count].Cells["Area"].Value);
                if (value < Convert.ToDouble(SearchBox.Value))
                {
                    indexes.Add(count);
                }
            }
            dataGridView1.CurrentCell = null;
            foreach (int index in indexes)
            {
                dataGridView1.Rows[index].Visible = false;
            }
        }

        private void DisableControls()
        {
            triangleControl1.Visible = false;
            circleControl1.Visible = false;
            rectangleControl1.Visible = false;
        }

        private void ModifyObject_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                CreateFigure modifyFigureForm = new CreateFigure()
                {
                    figure = _figures[dataGridView1.CurrentRow.Index],
                    ReadOnly = false
                };

                modifyFigureForm.ShowDialog();

                if (modifyFigureForm.DialogResult != DialogResult.OK) return;
                if (modifyFigureForm.figure != null)
                {
                    _figures[dataGridView1.CurrentRow.Index] = modifyFigureForm.figure;
                    figureBindingSource.ResetCurrentItem();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var figure = _figures[dataGridView1.CurrentRow.Index];
            if (figure is Triangle triangle)
            {
                triangleControl1.Visible = true;
                rectangleControl1.Visible = false;
                circleControl1.Visible = false;
                triangleControl1.ReadOnly = true;
                triangleControl1.triangle = triangle;
            }
            else if (figure is Rectangle rectangle)
            {
                rectangleControl1.Visible = true;
                triangleControl1.Visible = false;
                circleControl1.Visible = false;
                rectangleControl1.ReadOnly = true;
                rectangleControl1.rectangle = rectangle;
            }
            else if (figure is Circle circle)
            {
                circleControl1.Visible = true;
                triangleControl1.Visible = false;
                rectangleControl1.Visible = false;
                circleControl1.ReadOnly = true;

                circleControl1.circle = circle;
            }

        }
    }
    
}