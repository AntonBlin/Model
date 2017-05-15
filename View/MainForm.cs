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
    public partial class MainForm : System.Windows.Forms.Form
    {
        private JsonSerializer serializer = new JsonSerializer();
        private object dataGridViewFigures;
        private bool _pointFixer;
        private string _filePath;
        private List<IFigures> _figureses;

        public MainForm()
        {
            InitializeComponent();
            _pointFixer = true;
            iFiguresBindingSource.DataSource = _figureses = new List<IFigures>(); 
        }



        /// <summary>
        /// Добавление данных в поля
        /// </summary>
        private void Addbutton_Click(object sender, EventArgs e)
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
        private void Removebutton_Click(object sender, EventArgs e)
        {
            iFiguresBindingSource.Remove(iFiguresBindingSource.Current);
        }

        /// <summary>
        /// Изменение 
        /// </summary>
        private void Modifybutton_Click(object sender, EventArgs e)
        {
            if (iFiguresBindingSource.Current != null)
            {
                var cof = new CreationForm();
                var index = iFiguresBindingSource.IndexOf(iFiguresBindingSource.Current);
                cof.Figures = (IFigures) iFiguresBindingSource.Current;
                iFiguresBindingSource.RemoveAt(index);
                cof.ShowDialog();
                var figure = cof.Figures;
                iFiguresBindingSource.Insert(index, figure);
                _pointFixer = false;
            }
            else
            {
                MessageBox.Show("Не выбрана запись. Выберите запись и повторите попытку.");
            }
        }


        // Закрыть окно
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Завершить программу?",
                "Завершение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Application.Exit();
        }

        //Открыть файл
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
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
                   _figureses = serializer.Deserialize<List<IFigures>>(jreader);
                }

            }
            iFiguresBindingSource.DataSource = _figureses;
        }

        //Сохранить файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
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
                    serializer.Serialize(jwriter, _figureses);
                }
                MessageBox.Show("Сохранено!");
            }
        }

        //Поиск 
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (_figureses != null)
            {
                if (comboBoxSearch.SelectedIndex != -1)
                {
                    string searchLine = textBoxSearch.Text;
                    switch (comboBoxSearch.SelectedItem.ToString())
                    {
                        case "Фигура":
                        {
                            iFiguresBindingSource.DataSource =_figureses.FindAll(
                                iFigures => iFigures.Name == searchLine);
                            break;
                        }
                        case "Объем":
                        {
                            iFiguresBindingSource.DataSource = _figureses.FindAll(
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
        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            iFiguresBindingSource.DataSource =_figureses;
        }

    }
}
