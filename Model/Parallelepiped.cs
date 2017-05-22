using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Model
{
    /// <summary>
    /// Класс параллелепипед
    /// </summary>
    public class Parallelepiped : IFigures
    {
        /// <summary>
        /// Высота
        /// </summary>
        private double _height;
        /// <summary>
        /// Длина
        /// </summary>
        private double _lenght;
        /// <summary>
        /// Ширина
        /// </summary>
        private double _width;


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
            var volume = Height * Lenght * Width;
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
        /// Длина
        /// </sumary>
        public double Lenght
        {
            get { return _lenght; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение не должно быть отрицательным, и равным нулю. Введите длину заново");
                _lenght = value;
            }
        }
        /// <summary>
        /// Ширина
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение не должно быть отрицательным, и равным нулю. Введите ширину заново");
                _width = value;
            }
        }
   
    }
}