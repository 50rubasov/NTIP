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
using System.Runtime.Serialization.Formatters.Binary;

namespace ViewAreas
{
    public partial class MainForm : Form
    {
       
        private List<IFigure> _figures;
        private CreateFigure _getAreaForm;
        private BinaryFormatter _formatter;

        public MainForm()
        {
            InitializeComponent();

            _getAreaForm = new CreateFigure(figureBindingSource);
            _figures = new List<IFigure>();
            _formatter = new BinaryFormatter();

            figureBindingSource.DataSource = _figures;
            dataGridView1.DataSource = figureBindingSource;
        }

        private void AddObject_Click(object sender, EventArgs e)
        {
            _getAreaForm.Show();
        }

        private void DeleteObject_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Удалить?",
                "Подтвердите",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dataGridView1.CurrentCellAddress.X >= 0)
                {
                    int index = dataGridView1.SelectedCells[0].RowIndex;
                    dataGridView1.Rows.RemoveAt(index);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    FileStream fileStream = new FileStream(openFileDialog1.FileName,
                    FileMode.OpenOrCreate);

                    List<IFigure> deserilizeSalarys = (List<IFigure>)_formatter.
                        Deserialize(fileStream);

                    figureBindingSource.Clear();

                    foreach (IFigure figure in deserilizeSalarys)
                    {
                        figureBindingSource.Add(figure);
                    }
                    fileStream.Dispose();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    FileStream fileStream = new FileStream(saveFileDialog1.FileName,
                    FileMode.Create);

                    _formatter.Serialize(fileStream, _figures);
                    fileStream.Dispose();

                    MessageBox.Show("Файл сохранен. \r\nПуть:" + saveFileDialog1.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
