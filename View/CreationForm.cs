using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class CreationForm : Form
    {
        public CreationForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Кнопка Отмена
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }



        public IFigures Figures
        {
            get
            {
                try
                {
                    var figure = iFigureControl1.Figures;
                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                    return null;
                }
                return iFigureControl1.Figures;
                
            }

            set { iFigureControl1.Figures = value; }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
