namespace ViewAreas
{
    partial class TriangleControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.labelA = new System.Windows.Forms.Label();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.labelH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownH.DecimalPlaces = 2;
            this.numericUpDownH.Location = new System.Drawing.Point(30, 31);
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownH.TabIndex = 27;
            this.numericUpDownH.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // labelA
            // 
            this.labelA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(7, 3);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(17, 17);
            this.labelA.TabIndex = 20;
            this.labelA.Text = "A";
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownA.DecimalPlaces = 2;
            this.numericUpDownA.Location = new System.Drawing.Point(30, 3);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownA.TabIndex = 24;
            this.numericUpDownA.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // labelH
            // 
            this.labelH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(6, 31);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(18, 17);
            this.labelH.TabIndex = 22;
            this.labelH.Text = "H";
            // 
            // TriangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownH);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.labelH);
            this.Name = "TriangleControl";
            this.Size = new System.Drawing.Size(164, 78);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownH;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.Label labelH;
    }
}
