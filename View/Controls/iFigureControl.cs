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
    public partial class iFigureControl : UserControl
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public iFigureControl()
        {
            InitializeComponent();
            parallelepipedControl1.Visible = false;
            pyramidControl1.Visible = false;
            sphereControl1.Visible = false;
        }

        /// <summary>
        /// Инициализация
        /// </summary>
        public IFigures Figures
        {
            get
            {
                IFigures Figures = null;

                int figureindex= comboBoxFigure.SelectedIndex;

                switch (figureindex)
                {
                    case 0:
                    {
                            Figures = sphereControl1.Sphere;
                            Figures.Name = "Шар";
                          break;
                    }
                    case 1:
                    {
                            Figures = pyramidControl1.Pyramid;
                            Figures.Name = "Пирамида";
                         break;
                    }
                    case 2:
                    {
                            Figures = parallelepipedControl1.Parallelepiped;
                            Figures.Name = "Параллелепипед";
                         break;
                     }
                }
                return Figures;
            }
            set
            {
                if (value is Sphere)
                {
                    sphereControl1.Sphere = (Sphere)value;
                    comboBoxFigure.SelectedIndex = 0;
                }
                if (value is Pyramid)
                {
                    pyramidControl1.Pyramid = (Pyramid) value;
                    comboBoxFigure.SelectedIndex = 1;
                }
                if (value is Parallelepiped)
                {
                    parallelepipedControl1.Parallelepiped = (Parallelepiped)value;
                    comboBoxFigure.SelectedIndex = 2;
                }
            }
        }

        private void comboBoxFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            sphereControl1.Visible = comboBoxFigure.SelectedIndex == 0;
            pyramidControl1.Visible = comboBoxFigure.SelectedIndex == 1;
            parallelepipedControl1.Visible = comboBoxFigure.SelectedIndex == 2;
        }
    }
}
