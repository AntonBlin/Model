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
    public partial class pyramidControl : UserControl
    {
        public pyramidControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация Пирамиды
        /// </summary>
        public Pyramid Pyramid
        {
            get
            {
                var pyramid = new Pyramid();

                try
                {
                    pyramid.Area = Convert.ToDouble(AreamaskedTextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Площадь не введена.");
                    throw exception;
                }
                try
                {
                    pyramid.Height = Convert.ToDouble(HeightmaskedTextBoxPYR.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Высота не введена.");
                    throw exception;
                }

                return pyramid;
            }
            set
            {
                AreamaskedTextBox.Text = value.Area.ToString();
                HeightmaskedTextBoxPYR.Text = value.Height.ToString();
            }
        }
    }
}
