using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// Интерфейс 
    /// </summary>
    public interface IFigures
    {
        /// <summary>
        /// Имя 
        /// </summary>
        String Name
        {
            get; set;
        }
        /// <summary>
        /// Объем
        /// </summary>
        double Volume
        {
            get; 
        }
    }

    
    //Список геометрических фигур
    public class FiguresList
    {
        public static List<IFigures> listFigures = new List<IFigures>();
    }
}
