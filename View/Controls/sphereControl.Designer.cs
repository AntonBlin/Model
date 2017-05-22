namespace View.Controls
{
    partial class sphereControl
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
            this.SpheregroupBox = new System.Windows.Forms.GroupBox();
            this.RadiusmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SpheregroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpheregroupBox
            // 
            this.SpheregroupBox.Controls.Add(this.RadiusmaskedTextBox);
            this.SpheregroupBox.Controls.Add(this.label3);
            this.SpheregroupBox.Location = new System.Drawing.Point(3, 3);
            this.SpheregroupBox.Name = "SpheregroupBox";
            this.SpheregroupBox.Size = new System.Drawing.Size(153, 74);
            this.SpheregroupBox.TabIndex = 19;
            this.SpheregroupBox.TabStop = false;
            this.SpheregroupBox.Text = "Шар";
            // 
            // RadiusmaskedTextBox
            // 
            this.RadiusmaskedTextBox.Location = new System.Drawing.Point(82, 29);
            this.RadiusmaskedTextBox.Name = "RadiusmaskedTextBox";
            this.RadiusmaskedTextBox.Size = new System.Drawing.Size(43, 20);
            this.RadiusmaskedTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Радиус";
            // 
            // sphereControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpheregroupBox);
            this.Name = "sphereControl";
            this.Size = new System.Drawing.Size(159, 83);
            this.SpheregroupBox.ResumeLayout(false);
            this.SpheregroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SpheregroupBox;
        private System.Windows.Forms.MaskedTextBox RadiusmaskedTextBox;
        private System.Windows.Forms.Label label3;
    }
}
