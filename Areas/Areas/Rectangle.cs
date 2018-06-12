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
    /// 
    /// </summary>
    public class Rectangle : IFigure
    {
        /// <summary>
        /// Сторона А
        /// </summary>
        [DataMember]
        private double _a;

        /// <summary>
        /// Сторона B
        /// </summary>
        [DataMember]
        private double _b;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="a">сторона А</param>
        /// <param name="b">сторона В</param>
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }
        /// <summary>
        /// Устанавливает или возвращает сторону А
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
        /// Устанавливает или возвращает сторону B
        /// </summary>
        public double B
        {
            get { return _b; }

            set
            {
                if (value <= 0 || value > 1000000000.0)
                {
                    throw new Exception("Сторона должна быть больше нуля и меньше 1000000000");
                }
                _b = value;
            }
        }
        /// <summary>
        /// Вычисление площади прямоугольника
        /// </summary>
        /// <returns>площадь прямоугольника</returns>
        public double Area
        {
            get { return A * B; } 
        }
        /// <summary>
        /// Возвращение типа фигуры
        /// </summary>
        public string Type
        {
            get { return "Прямоугольник"; }
        }
    }
}
