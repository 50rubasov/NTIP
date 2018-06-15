namespace ViewAreas
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DeleteObject = new System.Windows.Forms.Button();
            this.AddObject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Figure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.figureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ModifyObject = new System.Windows.Forms.Button();
            this.rectangleControl1 = new ViewAreas.RectangleControl();
            this.triangleControl1 = new ViewAreas.TriangleControl();
            this.circleControl1 = new ViewAreas.CircleControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.figureBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteObject
            // 
            this.DeleteObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteObject.Location = new System.Drawing.Point(193, 30);
            this.DeleteObject.Name = "DeleteObject";
            this.DeleteObject.Size = new System.Drawing.Size(162, 27);
            this.DeleteObject.TabIndex = 7;
            this.DeleteObject.Text = "Удалить объект";
            this.DeleteObject.UseVisualStyleBackColor = true;
            this.DeleteObject.Click += new System.EventHandler(this.DeleteObject_Click);
            // 
            // AddObject
            // 
            this.AddObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddObject.Location = new System.Drawing.Point(6, 30);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(181, 27);
            this.AddObject.TabIndex = 6;
            this.AddObject.Text = "Добавить объект";
            this.AddObject.UseCompatibleTextRendering = true;
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Figure,
            this.Area});
            this.dataGridView1.DataSource = this.figureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(367, 161);
            this.dataGridView1.TabIndex = 5;
//            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Figure
            // 
            this.Figure.DataPropertyName = "Type";
            this.Figure.HeaderText = "Фигура";
            this.Figure.Name = "Figure";
            this.Figure.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "Area";
            this.Area.HeaderText = "Площадь";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ModifyObject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SearchBox);
            this.groupBox1.Controls.Add(this.AddObject);
            this.groupBox1.Controls.Add(this.DeleteObject);
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GridControl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поиск площади больше";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(193, 95);
            this.SearchBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(162, 22);
            this.SearchBox.TabIndex = 10;
            this.SearchBox.ValueChanged += new System.EventHandler(this.SearchBox_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ModifyObject
            // 
            this.ModifyObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModifyObject.Location = new System.Drawing.Point(99, 63);
            this.ModifyObject.Name = "ModifyObject";
            this.ModifyObject.Size = new System.Drawing.Size(181, 26);
            this.ModifyObject.TabIndex = 12;
            this.ModifyObject.Text = "Изменить объект";
            this.ModifyObject.UseVisualStyleBackColor = true;
            this.ModifyObject.Click += new System.EventHandler(this.ModifyObject_Click);
            // 
            // rectangleControl1
            // 
            this.rectangleControl1.Location = new System.Drawing.Point(12, 203);
            this.rectangleControl1.Name = "rectangleControl1";
            this.rectangleControl1.ReadOnly = false;
            this.rectangleControl1.Size = new System.Drawing.Size(99, 57);
            this.rectangleControl1.TabIndex = 10;
            // 
            // triangleControl1
            // 
            this.triangleControl1.Location = new System.Drawing.Point(12, 203);
            this.triangleControl1.Name = "triangleControl1";
            this.triangleControl1.ReadOnly = false;
            this.triangleControl1.Size = new System.Drawing.Size(99, 57);
            this.triangleControl1.TabIndex = 11;
            // 
            // circleControl1
            // 
            this.circleControl1.Location = new System.Drawing.Point(12, 203);
            this.circleControl1.Name = "circleControl1";
            this.circleControl1.ReadOnly = false;
            this.circleControl1.Size = new System.Drawing.Size(99, 35);
            this.circleControl1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 419);
            this.Controls.Add(this.circleControl1);
            this.Controls.Add(this.triangleControl1);
            this.Controls.Add(this.rectangleControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(409, 380);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.figureBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteObject;
        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource figureBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Figure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.Button ModifyObject;
        private RectangleControl rectangleControl1;
        private TriangleControl triangleControl1;
        private CircleControl circleControl1;
    }
}

