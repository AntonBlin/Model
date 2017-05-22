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
    public partial class sphereControl : UserControl
    {
        public sphereControl()
        {
            InitializeComponent();
        }

        public Sphere Sphere
        {
            get
            {
                var sphere = new Sphere();

                try
                {
                    sphere.Radius = Convert.ToDouble(RadiusmaskedTextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Радиус шара не введен!");
                    throw exception;
                }

                return sphere;
            }

            set
            {
                RadiusmaskedTextBox.Text = value.Radius.ToString();

            }
        }

    }
}
