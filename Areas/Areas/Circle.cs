using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Areas
{
    [DataContract]
    /// <summary>
    /// Площадь круга
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        [DataMember]
        private double _r;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="r"> Радиус</param>
        public Circle(double r)
        {
            R = r;
        }
        /// <summary>
        /// установить или возвратить радиус
        /// </summary>
        public double R
        {
            get { return _r; }

            set
            {
                if (value <= 0 || value > 1000000000.0)
                {
                    throw new Exception("Основание должно быть больше нуля и меньше 1000000000.0");
                }
                _r = value;
            }
        }
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns>площаь круга</returns>
        public double Area
        {
            get { return 2 * Math.PI * R; }
        }
        /// <summary>
        /// Возвращение типа фигуры
        /// </summary>
        public string Type
        {
            get { return "Круг"; }
        }
    }
}
