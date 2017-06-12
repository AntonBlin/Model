namespace View
{
    partial class mainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.figuresGroupBox = new System.Windows.Forms.GroupBox();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchlabel = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.modifybutton = new System.Windows.Forms.Button();
            this.removebutton = new System.Windows.Forms.Button();
            this.figuresdataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iFiguresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addbutton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.figuresGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figuresdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFiguresBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // figuresGroupBox
            // 
            this.figuresGroupBox.Controls.Add(this.refreshbutton);
            this.figuresGroupBox.Controls.Add(this.searchcomboBox);
            this.figuresGroupBox.Controls.Add(this.searchbutton);
            this.figuresGroupBox.Controls.Add(this.searchlabel);
            this.figuresGroupBox.Controls.Add(this.searchtextBox);
            this.figuresGroupBox.Controls.Add(this.modifybutton);
            this.figuresGroupBox.Controls.Add(this.removebutton);
            this.figuresGroupBox.Controls.Add(this.figuresdataGridView);
            this.figuresGroupBox.Controls.Add(this.addbutton);
            this.figuresGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figuresGroupBox.Location = new System.Drawing.Point(0, 24);
            this.figuresGroupBox.Name = "figuresGroupBox";
            this.figuresGroupBox.Size = new System.Drawing.Size(420, 206);
            this.figuresGroupBox.TabIndex = 0;
            this.figuresGroupBox.TabStop = false;
            this.figuresGroupBox.Text = "Таблица";
            // 
            // refreshbutton
            // 
            this.refreshbutton.Location = new System.Drawing.Point(220, 111);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(75, 40);
            this.refreshbutton.TabIndex = 25;
            this.refreshbutton.Text = "Обновить";
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // searchcomboBox
            // 
            this.searchcomboBox.FormattingEnabled = true;
            this.searchcomboBox.Items.AddRange(new object[] {
            "Фигура",
            "Объем"});
            this.searchcomboBox.Location = new System.Drawing.Point(301, 55);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(103, 21);
            this.searchcomboBox.TabIndex = 24;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(301, 82);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(107, 23);
            this.searchbutton.TabIndex = 22;
            this.searchbutton.Text = "Поиск";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchlabel
            // 
            this.searchlabel.AutoSize = true;
            this.searchlabel.Location = new System.Drawing.Point(330, 13);
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(39, 13);
            this.searchlabel.TabIndex = 5;
            this.searchlabel.Text = "Поиск";
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(301, 29);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(103, 20);
            this.searchtextBox.TabIndex = 4;
            // 
            // modifybutton
            // 
            this.modifybutton.Location = new System.Drawing.Point(220, 65);
            this.modifybutton.Name = "modifybutton";
            this.modifybutton.Size = new System.Drawing.Size(75, 40);
            this.modifybutton.TabIndex = 3;
            this.modifybutton.Text = "Изменить";
            this.modifybutton.UseVisualStyleBackColor = true;
            this.modifybutton.Click += new System.EventHandler(this.modifybutton_Click);
            // 
            // removebutton
            // 
            this.removebutton.Location = new System.Drawing.Point(220, 157);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(75, 40);
            this.removebutton.TabIndex = 2;
            this.removebutton.Text = "Удалить";
            this.removebutton.UseMnemonic = false;
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // figuresdataGridView
            // 
            this.figuresdataGridView.AutoGenerateColumns = false;
            this.figuresdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.figuresdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.figuresdataGridView.DataSource = this.iFiguresBindingSource;
            this.figuresdataGridView.Location = new System.Drawing.Point(7, 19);
            this.figuresdataGridView.Name = "figuresdataGridView";
            this.figuresdataGridView.RowHeadersVisible = false;
            this.figuresdataGridView.Size = new System.Drawing.Size(207, 178);
            this.figuresdataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фигура";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Volume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Объем";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // iFiguresBindingSource
            // 
            this.iFiguresBindingSource.DataSource = typeof(Model.IFigures);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(220, 19);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 40);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "Добавить";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(420, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fileToolStripMenuItem.Text = "Опции";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Закрыть";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 230);
            this.Controls.Add(this.figuresGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(436, 269);
            this.MinimumSize = new System.Drawing.Size(436, 269);
            this.Name = "mainForm";
            this.Text = "Тригонометрические фигуры";
            this.figuresGroupBox.ResumeLayout(false);
            this.figuresGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figuresdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFiguresBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox figuresGroupBox;
        private System.Windows.Forms.DataGridView figuresdataGridView;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.BindingSource iFiguresBindingSource;
        private System.Windows.Forms.Button modifybutton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label searchlabel;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox searchcomboBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button refreshbutton;
    }
}

