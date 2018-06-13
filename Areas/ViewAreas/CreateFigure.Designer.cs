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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.triangleControl1 = new ViewAreas.TriangleControl();
            this.rectangleControl1 = new ViewAreas.RectangleControl();
            this.circleControl1 = new ViewAreas.CircleControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFigureButton
            // 
            this.AddFigureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddFigureButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddFigureButton.Location = new System.Drawing.Point(7, 171);
            this.AddFigureButton.Name = "AddFigureButton";
            this.AddFigureButton.Size = new System.Drawing.Size(110, 23);
            this.AddFigureButton.TabIndex = 0;
            this.AddFigureButton.Text = "Добавить";
            this.AddFigureButton.UseVisualStyleBackColor = true;
            this.AddFigureButton.Visible = false;
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
            this.SelectFigureBox.Size = new System.Drawing.Size(214, 24);
            this.SelectFigureBox.TabIndex = 1;
            this.SelectFigureBox.SelectedIndexChanged += new System.EventHandler(this.SelectFigureBox_SelectedIndexChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(123, 171);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 23);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.triangleControl1);
            this.groupBox1.Controls.Add(this.rectangleControl1);
            this.groupBox1.Controls.Add(this.circleControl1);
            this.groupBox1.Controls.Add(this.SelectFigureBox);
            this.groupBox1.Controls.Add(this.AddFigureButton);
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 200);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите фигуру";
            // 
            // triangleControl1
            // 
            this.triangleControl1.Location = new System.Drawing.Point(6, 59);
            this.triangleControl1.Name = "triangleControl1";
            this.triangleControl1.ReadOnly = false;
            this.triangleControl1.Size = new System.Drawing.Size(99, 57);
            this.triangleControl1.TabIndex = 23;
            // 
            // rectangleControl1
            // 
            this.rectangleControl1.Location = new System.Drawing.Point(6, 59);
            this.rectangleControl1.Name = "rectangleControl1";
            this.rectangleControl1.ReadOnly = false;
            this.rectangleControl1.Size = new System.Drawing.Size(99, 57);
            this.rectangleControl1.TabIndex = 22;
            // 
            // circleControl1
            // 
            this.circleControl1.Location = new System.Drawing.Point(6, 59);
            this.circleControl1.Name = "circleControl1";
            this.circleControl1.ReadOnly = false;
            this.circleControl1.Size = new System.Drawing.Size(99, 35);
            this.circleControl1.TabIndex = 21;
            // 
            // CreateFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 222);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(270, 269);
            this.Name = "CreateFigure";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetAreaForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddFigureButton;
        private System.Windows.Forms.ComboBox SelectFigureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private TriangleControl triangleControl1;
        private RectangleControl rectangleControl1;
        private CircleControl circleControl1;
    }
}