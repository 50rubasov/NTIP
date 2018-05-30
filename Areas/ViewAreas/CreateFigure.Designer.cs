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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Triangle",
            "Rectangle",
            "Circle"});
            this.comboBox1.Location = new System.Drawing.Point(10, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(9, 58);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(17, 17);
            this.labelA.TabIndex = 6;
            this.labelA.Text = "A";
            this.labelA.Visible = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(8, 86);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 17);
            this.labelB.TabIndex = 7;
            this.labelB.Text = "B";
            this.labelB.Visible = false;
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(9, 83);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(18, 17);
            this.labelH.TabIndex = 8;
            this.labelH.Text = "H";
            this.labelH.Visible = false;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(10, 55);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(18, 17);
            this.labelR.TabIndex = 9;
            this.labelR.Text = "R";
            this.labelR.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Выберите фигуру";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.DecimalPlaces = 2;
            this.numericUpDownA.Location = new System.Drawing.Point(34, 53);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(54, 22);
            this.numericUpDownA.TabIndex = 16;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.DecimalPlaces = 2;
            this.numericUpDownB.Location = new System.Drawing.Point(34, 80);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(54, 22);
            this.numericUpDownB.TabIndex = 17;
            // 
            // numericUpDownR
            // 
            this.numericUpDownR.DecimalPlaces = 2;
            this.numericUpDownR.Location = new System.Drawing.Point(34, 53);
            this.numericUpDownR.Name = "numericUpDownR";
            this.numericUpDownR.Size = new System.Drawing.Size(54, 22);
            this.numericUpDownR.TabIndex = 18;
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.DecimalPlaces = 2;
            this.numericUpDownH.Location = new System.Drawing.Point(34, 80);
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(54, 22);
            this.numericUpDownH.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Случайные значения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CreateFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 177);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDownH);
            this.Controls.Add(this.numericUpDownR);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "CreateFigure";
            this.Text = "GetAreaForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownR;
        private System.Windows.Forms.NumericUpDown numericUpDownH;
        private System.Windows.Forms.Button button3;
    }
}