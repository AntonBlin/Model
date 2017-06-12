using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Newtonsoft.Json;

namespace View
{
    class Serializer
    {
        private static JsonSerializer serializer = new JsonSerializer();

        public static void Serilization(List<IFigures> figure, string filename)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer
            {
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto
            };

            using (StreamWriter streamWriter = new StreamWriter(filename))
            {
                using (Newtonsoft.Json.JsonWriter jwriter = new Newtonsoft.Json.JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jwriter, figure);
                }
                MessageBox.Show(@"Сохранено!");
            }
        }

        public static List<IFigures> Deserilization(string filename)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer
            {
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto
            };

            List<IFigures> _figure = null;
            using (StreamReader streamReader = new StreamReader(filename))
            {
                using (Newtonsoft.Json.JsonReader jreader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    _figure = serializer.Deserialize<List<IFigures>>(jreader);
                }
            }
            return _figure;
        }
    }

   
}
