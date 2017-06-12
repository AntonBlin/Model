namespace View.Controls
{
    partial class iFigureControl
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
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.sphereControl1 = new View.Controls.sphereControl();
            this.pyramidControl1 = new View.Controls.pyramidControl();
            this.parallelepipedControl1 = new View.Controls.parallelepipedControl();
            this.SuspendLayout();
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Items.AddRange(new object[] {
            "Шар",
            "Пирамида",
            "Параллелепипед"});
            this.comboBoxFigure.Location = new System.Drawing.Point(5, 13);
            this.comboBoxFigure.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(159, 21);
            this.comboBoxFigure.TabIndex = 3;
            this.comboBoxFigure.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigure_SelectedIndexChanged);
            // 
            // sphereControl1
            // 
            this.sphereControl1.Location = new System.Drawing.Point(5, 50);
            this.sphereControl1.Name = "sphereControl1";
            this.sphereControl1.Size = new System.Drawing.Size(159, 83);
            this.sphereControl1.TabIndex = 2;
            // 
            // pyramidControl1
            // 
            this.pyramidControl1.Location = new System.Drawing.Point(5, 50);
            this.pyramidControl1.Name = "pyramidControl1";
            this.pyramidControl1.Size = new System.Drawing.Size(159, 93);
            this.pyramidControl1.TabIndex = 1;
            // 
            // parallelepipedControl1
            // 
            this.parallelepipedControl1.Location = new System.Drawing.Point(3, 50);
            this.parallelepipedControl1.Name = "parallelepipedControl1";
            this.parallelepipedControl1.Size = new System.Drawing.Size(161, 112);
            this.parallelepipedControl1.TabIndex = 0;
            // 
            // iFigureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxFigure);
            this.Controls.Add(this.sphereControl1);
            this.Controls.Add(this.pyramidControl1);
            this.Controls.Add(this.parallelepipedControl1);
            this.Name = "iFigureControl";
            this.Size = new System.Drawing.Size(171, 182);
            this.ResumeLayout(false);

        }

        #endregion

        private parallelepipedControl parallelepipedControl1;
        private pyramidControl pyramidControl1;
        private sphereControl sphereControl1;
        private System.Windows.Forms.ComboBox comboBoxFigure;
    }
}
