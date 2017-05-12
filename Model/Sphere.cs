using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// Класс шар
    /// </summary>
	public class Sphere : IFigures
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private double _radius;

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
                var volume = 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;
                return Math.Round(volume);
            }
        }
     
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение не должно быть отрицательным, введите радиус заново");
                _radius = value;
            }
        }
      
    }
}
