namespace ViewAreas
{
    partial class CircleControl
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
            this.numericUpDownR = new System.Windows.Forms.NumericUpDown();
            this.labelR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownR
            // 
            this.numericUpDownR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownR.DecimalPlaces = 2;
            this.numericUpDownR.Location = new System.Drawing.Point(27, 3);
            this.numericUpDownR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownR.Name = "numericUpDownR";
            this.numericUpDownR.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownR.TabIndex = 20;
            this.numericUpDownR.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // labelR
            // 
            this.labelR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(3, 3);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(18, 17);
            this.labelR.TabIndex = 19;
            this.labelR.Text = "R";
            // 
            // CircleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownR);
            this.Controls.Add(this.labelR);
            this.Name = "CircleControl";
            this.Size = new System.Drawing.Size(99, 35);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownR;
        private System.Windows.Forms.Label labelR;
    }
}
