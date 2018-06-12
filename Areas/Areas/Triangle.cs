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
    /// Плозадь треугольника
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// сторона А
        /// </summary>
        [DataMember]
        private double _a;
        /// <summary>
        /// высота
        /// </summary>
        [DataMember]
        private double _h;
  
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="a">сторона А</param>
        /// <param name="h">высота H</param>
        public Triangle(double a, double h)
        {
            A = a;
            H = h;
        }
        /// <summary>
        /// Установить или возвратить сторону А
        /// </summary>
        public double A
        {
            get { return _a; }

            set
            {
                if (value <= 0 || value > 1000000000.0)
                {
                    throw new Exception("Сторона должна быть больше нуля и меньше 1000000000");
                }
                _a = value;
            }
        }
        /// <summary>
        /// Установить или возвратить высоту
        /// </summary>
        public double H
        {
            get { return _h; }

            set
            {
                if (value <= 0 || value > 1000000000.0)
                {
                    throw new Exception("Основание должно быть больше нуля и меньше 1000000000");
                }
                _h = value;
            }

        }
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>площадь</returns>
        public double Area
        {                     
            get { return 0.5 * A * H; }
        }
        /// <summary>
        /// Возвращение типа фигуры
        /// </summary>
        public string Type
        {
            get { return "Треугольник"; }
        }
    }
}
