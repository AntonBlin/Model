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

        private IFigures _Figures;
        private bool _RadiusmaskedTextBox = false;
        private bool _HeightmaskedTextBoxPYR = false;
        private bool _AreamasketTextBox = false;
        private bool _HeightmaskedTextBoxPAR = false;
        private bool _LenghtmaskedTextBox = false;
        private bool _WightmaskedTextBox = false;

        /// <summary>
        /// Видимость groupBox
        /// </summary>
        private void FigureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FigureComboBox.SelectedIndex)
            {
                case 0:
                {
                    SpheregroupBox.Enabled = true;
                    PyramidgroupBox.Enabled = false;
                    ParallelepipedgroupBox.Enabled = false;
                    break;
                }
                case 1:
                {
                    SpheregroupBox.Enabled = false;
                    PyramidgroupBox.Enabled = true;
                    ParallelepipedgroupBox.Enabled = false;
                    break;
                }
                case 2:
                {
                    SpheregroupBox.Enabled = false;
                    PyramidgroupBox.Enabled = false;
                    ParallelepipedgroupBox.Enabled = true;
                    break;
                }
            }
        }


        private void CreationForm_Load(object sender, EventArgs e)
        {
            SpheregroupBox.Enabled = false;
            PyramidgroupBox.Enabled = false;
            ParallelepipedgroupBox.Enabled = false;
        }

        /// <summary>
        /// Кнопка Отмена
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Кнопка Добавления 
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            bool exitState = false;
            if ((RadiusmaskedTextBox.Text != "") || (HeightmaskedTextBoxPYR.Text != "") ||
                (AreamaskedTextBox.Text != "") || (HeightmaskedTextBoxPAR.Text != "") ||
                (LenghtmaskedTextBox.Text != "") || (WidthmaskedTextBox.Text != ""))
            {
                exitState = true;
            }
            if (FigureComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(@"Не была выбрана геометрическая фигура");
            }
            else if ((FigureComboBox.SelectedIndex == 0) && !(exitState))
            {
                if (!(_RadiusmaskedTextBox))
                    MessageBox.Show(@"Радиус шара не введен!");
                else
                    exitState = true;
            }
            else if ((FigureComboBox.SelectedIndex == 1) && !(exitState))
            {
                if (!(_HeightmaskedTextBoxPYR && _AreamasketTextBox))
                    MessageBox.Show(@"Высота или Площадь не введены!");
                else
                    exitState = true;
            }
            else if ((FigureComboBox.SelectedIndex == 2) && !(exitState))
            {
                if (!(_HeightmaskedTextBoxPAR && _LenghtmaskedTextBox && _WightmaskedTextBox))
                    MessageBox.Show(@"Высота, длина или ширина не введен!");
                else
                    exitState = true;
            }
            if (exitState)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        public IFigures Figures
        {
            get
            {
                if (FigureComboBox.SelectedIndex == 0)
                {
                    var sphere = new Sphere();

                    sphere.Radius = Convert.ToDouble(RadiusmaskedTextBox.Text);
                    _Figures = sphere;
                    sphere.Name = "Шар";
                }
                else if (FigureComboBox.SelectedIndex == 1)
                {
                    var pyramid = new Pyramid();

                    pyramid.Height = Convert.ToDouble(HeightmaskedTextBoxPYR.Text);
                    pyramid.Area = Convert.ToDouble(AreamaskedTextBox.Text);
                    _Figures = pyramid;
                    pyramid.Name = "Пирамида";
                }
                else if (FigureComboBox.SelectedIndex == 2)
                {
                    var parallelepiped = new Parallelepiped();

                    parallelepiped.Height = Convert.ToDouble(HeightmaskedTextBoxPAR.Text);
                    parallelepiped.Lenght = Convert.ToDouble(LenghtmaskedTextBox.Text);
                    parallelepiped.Width = Convert.ToDouble(WidthmaskedTextBox.Text);
                    _Figures = parallelepiped;
                    parallelepiped.Name = "Параллелепипед";
                }
                return _Figures;
            }
            set
            {
                _Figures = value;
                if (value is Model.Sphere)
                {
                    var sphere = (Model.Sphere) value;
                    FigureComboBox.SelectedIndex = 0;
                    RadiusmaskedTextBox.Text = Convert.ToString(sphere.Radius);

                }
                else if (value is Model.Pyramid)
                {
                    var pyramid = (Model.Pyramid) value;
                    FigureComboBox.SelectedIndex = 1;
                    HeightmaskedTextBoxPYR.Text = Convert.ToString(pyramid.Height);
                    AreamaskedTextBox.Text = Convert.ToString(pyramid.Area);
                }
                else if (value is Model.Parallelepiped)
                {
                    var parallelepiped = (Model.Parallelepiped) value;
                    FigureComboBox.SelectedIndex = 2;
                    HeightmaskedTextBoxPAR.Text = Convert.ToString(parallelepiped.Height);
                    LenghtmaskedTextBox.Text = Convert.ToString(parallelepiped.Lenght);
                    WidthmaskedTextBox.Text = Convert.ToString(parallelepiped.Width);
                }
            }
        }

        /// <summary>
        /// Если поле пустое
        /// </summary>
        private void RadiusmaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (RadiusmaskedTextBox.Text == "")
            {
                errorProvider.SetError(RadiusmaskedTextBox, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProvider.Clear();
                _RadiusmaskedTextBox = true;
            }
        }

        private void HeightmaskedTextBoxPYR_Leave(object sender, EventArgs e)
        {
            if (HeightmaskedTextBoxPYR.Text == "")
            {
                errorProvider.SetError(HeightmaskedTextBoxPYR, "Данное поле должно быть заполненным!");
            }
            else
            {
                errorProvider.Clear();
                _HeightmaskedTextBoxPYR = true;
            }
        }

        private void AreamaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (AreamaskedTextBox.Text == "")
            {
                errorProvider.SetError(AreamaskedTextBox, "Данное поле должно быть заполненным!");
            }
            else
            {
                errorProvider.Clear();
                _AreamasketTextBox = true;
            }
        }

        private void HeightmaskedTextBoxPAR_Leave(object sender, EventArgs e)
        {
            if (HeightmaskedTextBoxPAR.Text == "")
            {
                errorProvider.SetError(HeightmaskedTextBoxPAR, "Данное поле должно быть заполненным!");
            }
            else
            {
                errorProvider.Clear();
                _HeightmaskedTextBoxPAR = true;
            }
        }

        private void LenghtmaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (LenghtmaskedTextBox.Text == "")
            {
                errorProvider.SetError(LenghtmaskedTextBox, "Данное поле должно быть заполненным!");
            }
            else
            {
                errorProvider.Clear();
                _LenghtmaskedTextBox = true;
            }
        }

        private void WidthmaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (WidthmaskedTextBox.Text == "")
            {
                errorProvider.SetError(WidthmaskedTextBox, "Данное поле должно быть заполненным!");
            }
            else
            {
                errorProvider.Clear();
                _WightmaskedTextBox = true;
            }
        }

    }
}
