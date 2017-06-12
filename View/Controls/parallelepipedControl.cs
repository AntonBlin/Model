using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;


namespace View.Controls
{
    public partial class parallelepipedControl : UserControl
    {
        public parallelepipedControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация Параллелепипеда
        /// </summary>
        public Parallelepiped Parallelepiped
        {
            get
            {
                var parallelepiped = new Parallelepiped();

                try
                {
                    parallelepiped.Lenght = Convert.ToDouble(LenghtmaskedTextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Длина не введена.");
                    throw exception;
                }

                try
                {
                    parallelepiped.Height = Convert.ToDouble(HeightmaskedTextBoxPAR.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Высота не введена.");
                    throw exception;
                }

                try
                {
                    parallelepiped.Width = Convert.ToDouble(WidthmaskedTextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ширина не введена.");
                    throw exception;
                }
                return parallelepiped;
            }
            set
            {
                HeightmaskedTextBoxPAR.Text = value.Height.ToString();
                LenghtmaskedTextBox.Text = value.Lenght.ToString();
                WidthmaskedTextBox.Text = value.Width.ToString();
            }
        }
    }
}
