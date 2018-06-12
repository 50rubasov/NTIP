namespace ViewAreas
{
    partial class CreateFigure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddFigureButton = new System.Windows.Forms.Button();
            this.SelectFigureBox = new System.Windows.Forms.ComboBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.numericUpDownR = new System.Windows.Forms.NumericUpDown();
            this.RandomValueButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.triangleControl1 = new ViewAreas.TriangleControl();
            this.labelR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFigureButton
            // 
            this.AddFigureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddFigureButton.Location = new System.Drawing.Point(6, 260);
            this.AddFigureButton.Name = "AddFigureButton";
            this.AddFigureButton.Size = new System.Drawing.Size(87, 23);
            this.AddFigureButton.TabIndex = 0;
            this.AddFigureButton.Text = "Добавить";
            this.AddFigureButton.UseVisualStyleBackColor = true;
            this.AddFigureButton.Visible = false;
            this.AddFigureButton.Click += new System.EventHandler(this.AddFigureButton_Click);
            // 
            // SelectFigureBox
            // 
            this.SelectFigureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFigureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectFigureBox.FormattingEnabled = true;
            this.SelectFigureBox.Items.AddRange(new object[] {
            "Triangle",
            "Rectangle",
            "Circle"});
            this.SelectFigureBox.Location = new System.Drawing.Point(6, 29);
            this.SelectFigureBox.Name = "SelectFigureBox";
            this.SelectFigureBox.Size = new System.Drawing.Size(292, 24);
            this.SelectFigureBox.TabIndex = 1;
            this.SelectFigureBox.SelectedIndexChanged += new System.EventHandler(this.SelectFigureBox_SelectedIndexChanged);
            this.SelectFigureBox.VisibleChanged += new System.EventHandler(this.SelectFigureBox_VisibleChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(99, 260);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(93, 23);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Visible = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // numericUpDownR
            // 
            this.numericUpDownR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownR.DecimalPlaces = 2;
            this.numericUpDownR.Location = new System.Drawing.Point(29, 59);
            this.numericUpDownR.Name = "numericUpDownR";
            this.numericUpDownR.Size = new System.Drawing.Size(156, 22);
            this.numericUpDownR.TabIndex = 18;
            // 
            // RandomValueButton
            // 
            this.RandomValueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomValueButton.Location = new System.Drawing.Point(6, 289);
            this.RandomValueButton.Name = "RandomValueButton";
            this.RandomValueButton.Size = new System.Drawing.Size(186, 26);
            this.RandomValueButton.TabIndex = 20;
            this.RandomValueButton.Text = "Случайные значения";
            this.RandomValueButton.UseVisualStyleBackColor = true;
            this.RandomValueButton.Visible = false;
            this.RandomValueButton.Click += new System.EventHandler(this.RandomValueButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.triangleControl1);
            this.groupBox1.Controls.Add(this.SelectFigureBox);
            this.groupBox1.Controls.Add(this.RandomValueButton);
            this.groupBox1.Controls.Add(this.numericUpDownR);
            this.groupBox1.Controls.Add(this.AddFigureButton);
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Controls.Add(this.labelR);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 336);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите фигуру";
            // 
            // triangleControl1
            // 
            this.triangleControl1.Location = new System.Drawing.Point(23, 100);
            this.triangleControl1.Name = "triangleControl1";
            this.triangleControl1.ReadOnly = false;
            this.triangleControl1.Size = new System.Drawing.Size(169, 61);
            this.triangleControl1.TabIndex = 22;
            // 
            // labelR
            // 
            this.labelR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(6, 56);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(18, 17);
            this.labelR.TabIndex = 9;
            this.labelR.Text = "R";
            this.labelR.Visible = false;
            // 
            // CreateFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 556);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(245, 269);
            this.Name = "CreateFigure";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetAreaForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateFigure_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddFigureButton;
        private System.Windows.Forms.ComboBox SelectFigureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.NumericUpDown numericUpDownR;
        private System.Windows.Forms.Button RandomValueButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private TriangleControl triangleControl1;
        private System.Windows.Forms.Label labelR;
    }
}