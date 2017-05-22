using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// Класс пирамида 
    /// </summary>
    public class Pyramid : IFigures
    {
        /// <summary>
        /// Высота
        /// </summary>
        private double _height;
        /// <summary>
        /// Площадь пирамиды
        /// </summary>
        private double _area;


        /// <summary>
        /// Имя
        /// </summary>
        public string Name
        {
            get; set;
        }
        /// <summary>
        /// Объем 
        /// </summary>
        public double Volume
        {
            get
            {
                var volume = 1.0 / 3.0 * Height * Area;
                return Math.Round(volume);
            }
            

        }
        /// <summary>
        /// Высота
        /// </summary>
        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение не должно быть отрицательным, и равным нулю. Введите высоту заново");
                _height = value;
            }
        }
        /// <summary>
        /// Площадь
        /// </summary>
        public double Area
        {
            get { return _area; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение не должно быть отрицательным, и равным нулю. Введите сторону заново");
                _area = value;
            }
        }
 
    }
}
