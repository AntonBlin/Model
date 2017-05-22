namespace View.Controls
{
    partial class parallelepipedControl
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
            this.ParallelepipedgroupBox = new System.Windows.Forms.GroupBox();
            this.WidthmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LenghtmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HeightmaskedTextBoxPAR = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ParallelepipedgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParallelepipedgroupBox
            // 
            this.ParallelepipedgroupBox.Controls.Add(this.WidthmaskedTextBox);
            this.ParallelepipedgroupBox.Controls.Add(this.LenghtmaskedTextBox);
            this.ParallelepipedgroupBox.Controls.Add(this.HeightmaskedTextBoxPAR);
            this.ParallelepipedgroupBox.Controls.Add(this.label6);
            this.ParallelepipedgroupBox.Controls.Add(this.label5);
            this.ParallelepipedgroupBox.Controls.Add(this.label4);
            this.ParallelepipedgroupBox.Location = new System.Drawing.Point(3, 3);
            this.ParallelepipedgroupBox.Name = "ParallelepipedgroupBox";
            this.ParallelepipedgroupBox.Size = new System.Drawing.Size(153, 104);
            this.ParallelepipedgroupBox.TabIndex = 20;
            this.ParallelepipedgroupBox.TabStop = false;
            this.ParallelepipedgroupBox.Text = "Параллелепипед";
            // 
            // WidthmaskedTextBox
            // 
            this.WidthmaskedTextBox.Location = new System.Drawing.Point(85, 71);
            this.WidthmaskedTextBox.Name = "WidthmaskedTextBox";
            this.WidthmaskedTextBox.Size = new System.Drawing.Size(46, 20);
            this.WidthmaskedTextBox.TabIndex = 7;
            // 
            // LenghtmaskedTextBox
            // 
            this.LenghtmaskedTextBox.Location = new System.Drawing.Point(85, 45);
            this.LenghtmaskedTextBox.Name = "LenghtmaskedTextBox";
            this.LenghtmaskedTextBox.Size = new System.Drawing.Size(46, 20);
            this.LenghtmaskedTextBox.TabIndex = 6;
            // 
            // HeightmaskedTextBoxPAR
            // 
            this.HeightmaskedTextBoxPAR.Location = new System.Drawing.Point(85, 19);
            this.HeightmaskedTextBoxPAR.Name = "HeightmaskedTextBoxPAR";
            this.HeightmaskedTextBoxPAR.Size = new System.Drawing.Size(46, 20);
            this.HeightmaskedTextBoxPAR.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Длина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ширина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Высота";
            // 
            // parallelepipedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParallelepipedgroupBox);
            this.Name = "parallelepipedControl";
            this.Size = new System.Drawing.Size(161, 112);
            this.ParallelepipedgroupBox.ResumeLayout(false);
            this.ParallelepipedgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParallelepipedgroupBox;
        private System.Windows.Forms.MaskedTextBox WidthmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox LenghtmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox HeightmaskedTextBoxPAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
