using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace View
{
    public partial class mainForm : System.Windows.Forms.Form
    {
        private JsonSerializer serializer = new JsonSerializer();
        private object dataGridViewFigures;
        private bool _pointFixer;
        private string _filePath;
        private List<IFigures> _figures;
        
        public mainForm()
        {
            InitializeComponent();
            _pointFixer = true;
            iFiguresBindingSource.DataSource = _figures = new List<IFigures>(); 
        }   



        /// <summary>
        /// Добавление данных в поля
        /// </summary>
        private void addbutton_Click(object sender, EventArgs e)
        {
            CreationForm formAdd = new CreationForm();

            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                iFiguresBindingSource.Add(formAdd.Figures);
            }
        }

        /// <summary>
        /// Удаление строки 
        /// </summary>
        private void removebutton_Click(object sender, EventArgs e)
        {
            iFiguresBindingSource.Remove(iFiguresBindingSource.Current);
        }

        /// <summary>
        /// Изменение 
        /// </summary>
        private void modifybutton_Click(object sender, EventArgs e)
        {
            if (iFiguresBindingSource.Current != null)
            {
                var creat = new CreationForm();
                var index = iFiguresBindingSource.IndexOf(iFiguresBindingSource.Current);
                creat.Figures = (IFigures) iFiguresBindingSource.Current;
                iFiguresBindingSource.RemoveAt(index);
                creat.ShowDialog();
                var figure = creat.Figures;
                iFiguresBindingSource.Insert(index, figure);
                _pointFixer = false;
            }
            else
            {
                MessageBox.Show("Не выбрана запись. Выберите запись и повторите попытку.");
            }
        }


        // Закрыть окно
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Завершить программу?",
                "Завершение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Application.Exit();
        }

        //Открыть файл
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var serializer = new Newtonsoft.Json.JsonSerializer
            {
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto
            };
            openFileDialog.Filter = "Список фигур(.baa)| *.baa";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = openFileDialog.FileName;
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                using (Newtonsoft.Json.JsonReader jreader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                   _figures = serializer.Deserialize<List<IFigures>>(jreader);
                }

            }
            iFiguresBindingSource.DataSource = _figures;
        }

        //Сохранить файл
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer
            {
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto

            };

            saveFileDialog.Filter = "Список фигур(.baa)| *.baa";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = saveFileDialog.FileName;
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                using (Newtonsoft.Json.JsonWriter jwriter = new Newtonsoft.Json.JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jwriter, _figures);
                }
                MessageBox.Show("Сохранено!");
            }
        }

        //Поиск 
        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (_figures != null)
            {
                if (searchcomboBox.SelectedIndex != -1)
                {
                    string searchLine = searchtextBox.Text;
                    switch (searchcomboBox.SelectedItem.ToString())
                    {
                        case "Фигура":
                        {
                            iFiguresBindingSource.DataSource =_figures.FindAll(
                                iFigures => iFigures.Name == searchLine);
                            break;
                        }
                        case "Объем":
                        {
                            iFiguresBindingSource.DataSource = _figures.FindAll(
                                iFigures => iFigures.Volume.ToString() == searchLine);
                            break;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не выбрано поле поиска!");
                }
            }
                else
                {
                    MessageBox.Show("База пуста!");
                }
            
        }

        //Обновить таблицу
        private void refreshbutton_Click(object sender, EventArgs e)
        {
            iFiguresBindingSource.DataSource =_figures;
        }

    }
}
