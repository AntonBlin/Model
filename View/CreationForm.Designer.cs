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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationForm));
            this.AddButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            this.iFigureControl1 = new View.Controls.iFigureControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(13, 218);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(111, 29);
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
            this.CancelButton.Location = new System.Drawing.Point(130, 218);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 29);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // iFigureControl1
            // 
            this.iFigureControl1.Figures = null;
            this.iFigureControl1.Location = new System.Drawing.Point(13, 5);
            this.iFigureControl1.Margin = new System.Windows.Forms.Padding(4);
            this.iFigureControl1.Name = "iFigureControl1";
            this.iFigureControl1.Size = new System.Drawing.Size(227, 206);
            this.iFigureControl1.TabIndex = 22;
            // 
            // CreationForm
            // 
            this.ClientSize = new System.Drawing.Size(269, 257);
            this.Controls.Add(this.iFigureControl1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(285, 295);
            this.MinimumSize = new System.Drawing.Size(285, 295);
            this.Name = "CreationForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button CancelButton;
        private Controls.iFigureControl iFigureControl1;
    }
}