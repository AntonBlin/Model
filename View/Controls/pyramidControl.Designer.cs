namespace View.Controls
{
    partial class pyramidControl
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
            this.PyramidgroupBox = new System.Windows.Forms.GroupBox();
            this.HeightmaskedTextBoxPYR = new System.Windows.Forms.MaskedTextBox();
            this.AreamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PyramidgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PyramidgroupBox
            // 
            this.PyramidgroupBox.Controls.Add(this.HeightmaskedTextBoxPYR);
            this.PyramidgroupBox.Controls.Add(this.AreamaskedTextBox);
            this.PyramidgroupBox.Controls.Add(this.label2);
            this.PyramidgroupBox.Controls.Add(this.label1);
            this.PyramidgroupBox.Location = new System.Drawing.Point(3, 3);
            this.PyramidgroupBox.Name = "PyramidgroupBox";
            this.PyramidgroupBox.Size = new System.Drawing.Size(153, 87);
            this.PyramidgroupBox.TabIndex = 13;
            this.PyramidgroupBox.TabStop = false;
            this.PyramidgroupBox.Text = "Пирамида";
            // 
            // HeightmaskedTextBoxPYR
            // 
            this.HeightmaskedTextBoxPYR.Location = new System.Drawing.Point(85, 26);
            this.HeightmaskedTextBoxPYR.Name = "HeightmaskedTextBoxPYR";
            this.HeightmaskedTextBoxPYR.Size = new System.Drawing.Size(46, 20);
            this.HeightmaskedTextBoxPYR.TabIndex = 6;
            // 
            // AreamaskedTextBox
            // 
            this.AreamaskedTextBox.HideSelection = false;
            this.AreamaskedTextBox.Location = new System.Drawing.Point(85, 52);
            this.AreamaskedTextBox.Name = "AreamaskedTextBox";
            this.AreamaskedTextBox.Size = new System.Drawing.Size(46, 20);
            this.AreamaskedTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Площадь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота";
            // 
            // pyramidControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PyramidgroupBox);
            this.Name = "pyramidControl";
            this.Size = new System.Drawing.Size(159, 93);
            this.PyramidgroupBox.ResumeLayout(false);
            this.PyramidgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PyramidgroupBox;
        private System.Windows.Forms.MaskedTextBox HeightmaskedTextBoxPYR;
        private System.Windows.Forms.MaskedTextBox AreamaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
