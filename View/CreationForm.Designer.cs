namespace View
{
    partial class CreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.FigureComboBox = new System.Windows.Forms.ComboBox();
            this.PyramidgroupBox = new System.Windows.Forms.GroupBox();
            this.HeightmaskedTextBoxPYR = new System.Windows.Forms.MaskedTextBox();
            this.AreamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpheregroupBox = new System.Windows.Forms.GroupBox();
            this.RadiusmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ParallelepipedgroupBox = new System.Windows.Forms.GroupBox();
            this.WidthmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LenghtmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HeightmaskedTextBoxPAR = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            this.PyramidgroupBox.SuspendLayout();
            this.SpheregroupBox.SuspendLayout();
            this.ParallelepipedgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 28);
            this.label11.TabIndex = 15;
            this.label11.Text = "Выберите фигуру";
            // 
            // FigureComboBox
            // 
            this.FigureComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Шар",
            "Пирамида",
            "Параллелепипед"});
            this.FigureComboBox.FormattingEnabled = true;
            this.FigureComboBox.Items.AddRange(new object[] {
            "Шар",
            "Пирамида",
            "Параллелепипед"});
            this.FigureComboBox.Location = new System.Drawing.Point(116, 6);
            this.FigureComboBox.Name = "FigureComboBox";
            this.FigureComboBox.Size = new System.Drawing.Size(115, 21);
            this.FigureComboBox.TabIndex = 13;
            this.FigureComboBox.SelectedIndexChanged += new System.EventHandler(this.FigureComboBox_SelectedIndexChanged);
            // 
            // PyramidgroupBox
            // 
            this.PyramidgroupBox.Controls.Add(this.HeightmaskedTextBoxPYR);
            this.PyramidgroupBox.Controls.Add(this.AreamaskedTextBox);
            this.PyramidgroupBox.Controls.Add(this.label2);
            this.PyramidgroupBox.Controls.Add(this.label1);
            this.PyramidgroupBox.Location = new System.Drawing.Point(171, 50);
            this.PyramidgroupBox.Name = "PyramidgroupBox";
            this.PyramidgroupBox.Size = new System.Drawing.Size(153, 87);
            this.PyramidgroupBox.TabIndex = 12;
            this.PyramidgroupBox.TabStop = false;
            this.PyramidgroupBox.Text = "Пирамида";
            // 
            // HeightmaskedTextBoxPYR
            // 
            this.HeightmaskedTextBoxPYR.Location = new System.Drawing.Point(85, 26);
            this.HeightmaskedTextBoxPYR.Name = "HeightmaskedTextBoxPYR";
            this.HeightmaskedTextBoxPYR.Size = new System.Drawing.Size(46, 20);
            this.HeightmaskedTextBoxPYR.TabIndex = 6;
            this.HeightmaskedTextBoxPYR.Leave += new System.EventHandler(this.HeightmaskedTextBoxPYR_Leave);
            // 
            // AreamaskedTextBox
            // 
            this.AreamaskedTextBox.HideSelection = false;
            this.AreamaskedTextBox.Location = new System.Drawing.Point(85, 52);
            this.AreamaskedTextBox.Name = "AreamaskedTextBox";
            this.AreamaskedTextBox.Size = new System.Drawing.Size(46, 20);
            this.AreamaskedTextBox.TabIndex = 5;
            this.AreamaskedTextBox.Leave += new System.EventHandler(this.AreamaskedTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
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
            // SpheregroupBox
            // 
            this.SpheregroupBox.Controls.Add(this.RadiusmaskedTextBox);
            this.SpheregroupBox.Controls.Add(this.label3);
            this.SpheregroupBox.Location = new System.Drawing.Point(12, 50);
            this.SpheregroupBox.Name = "SpheregroupBox";
            this.SpheregroupBox.Size = new System.Drawing.Size(153, 74);
            this.SpheregroupBox.TabIndex = 18;
            this.SpheregroupBox.TabStop = false;
            this.SpheregroupBox.Text = "Шар";
            // 
            // RadiusmaskedTextBox
            // 
            this.RadiusmaskedTextBox.Location = new System.Drawing.Point(82, 29);
            this.RadiusmaskedTextBox.Name = "RadiusmaskedTextBox";
            this.RadiusmaskedTextBox.Size = new System.Drawing.Size(43, 20);
            this.RadiusmaskedTextBox.TabIndex = 3;
            this.RadiusmaskedTextBox.Leave += new System.EventHandler(this.RadiusmaskedTextBox_Leave);
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
            // ParallelepipedgroupBox
            // 
            this.ParallelepipedgroupBox.Controls.Add(this.WidthmaskedTextBox);
            this.ParallelepipedgroupBox.Controls.Add(this.LenghtmaskedTextBox);
            this.ParallelepipedgroupBox.Controls.Add(this.HeightmaskedTextBoxPAR);
            this.ParallelepipedgroupBox.Controls.Add(this.label6);
            this.ParallelepipedgroupBox.Controls.Add(this.label5);
            this.ParallelepipedgroupBox.Controls.Add(this.label4);
            this.ParallelepipedgroupBox.Location = new System.Drawing.Point(330, 50);
            this.ParallelepipedgroupBox.Name = "ParallelepipedgroupBox";
            this.ParallelepipedgroupBox.Size = new System.Drawing.Size(153, 104);
            this.ParallelepipedgroupBox.TabIndex = 19;
            this.ParallelepipedgroupBox.TabStop = false;
            this.ParallelepipedgroupBox.Text = "Параллелепипед";
            // 
            // WidthmaskedTextBox
            // 
            this.WidthmaskedTextBox.Location = new System.Drawing.Point(85, 74);
            this.WidthmaskedTextBox.Name = "WidthmaskedTextBox";
            this.WidthmaskedTextBox.Size = new System.Drawing.Size(46, 20);
            this.WidthmaskedTextBox.TabIndex = 7;
            this.WidthmaskedTextBox.Leave += new System.EventHandler(this.WidthmaskedTextBox_Leave);
            // 
            // LenghtmaskedTextBox
            // 
            this.LenghtmaskedTextBox.Location = new System.Drawing.Point(85, 48);
            this.LenghtmaskedTextBox.Name = "LenghtmaskedTextBox";
            this.LenghtmaskedTextBox.Size = new System.Drawing.Size(46, 20);
            this.LenghtmaskedTextBox.TabIndex = 6;
            this.LenghtmaskedTextBox.Leave += new System.EventHandler(this.LenghtmaskedTextBox_Leave);
            // 
            // HeightmaskedTextBoxPAR
            // 
            this.HeightmaskedTextBoxPAR.Location = new System.Drawing.Point(85, 19);
            this.HeightmaskedTextBoxPAR.Name = "HeightmaskedTextBoxPAR";
            this.HeightmaskedTextBoxPAR.Size = new System.Drawing.Size(46, 20);
            this.HeightmaskedTextBoxPAR.TabIndex = 5;
            this.HeightmaskedTextBoxPAR.Leave += new System.EventHandler(this.HeightmaskedTextBoxPAR_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Длина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ширина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Высота";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 209);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(111, 21);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(129, 209);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 21);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreationForm
            // 
            this.ClientSize = new System.Drawing.Size(501, 254);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PyramidgroupBox);
            this.Controls.Add(this.SpheregroupBox);
            this.Controls.Add(this.ParallelepipedgroupBox);
            this.Controls.Add(this.FigureComboBox);
            this.Controls.Add(this.label11);
            this.Name = "CreationForm";
            this.Load += new System.EventHandler(this.CreationForm_Load);
            this.PyramidgroupBox.ResumeLayout(false);
            this.PyramidgroupBox.PerformLayout();
            this.SpheregroupBox.ResumeLayout(false);
            this.SpheregroupBox.PerformLayout();
            this.ParallelepipedgroupBox.ResumeLayout(false);
            this.ParallelepipedgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox FigureComboBox;
        private System.Windows.Forms.GroupBox PyramidgroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox AreamaskedTextBox;
        private System.Windows.Forms.MaskedTextBox HeightmaskedTextBoxPYR;
        private System.Windows.Forms.GroupBox SpheregroupBox;
        private System.Windows.Forms.MaskedTextBox RadiusmaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox ParallelepipedgroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox WidthmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox LenghtmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox HeightmaskedTextBoxPAR;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button CancelButton;
    }
}