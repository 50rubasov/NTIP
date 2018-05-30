using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    [Serializable]
    /// <summary>
    /// 
    /// </summary>
    public class Rectangle : IFigure
    {
        /// <summary>
        /// Сторона А
        /// </summary>
        private double _a;

        /// <summary>
        /// Сторона B
        /// </summary>
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
            get
            {
                if (_a < 0)
                {
                    throw new Exception("Сторона должна быть больше нуля");
                }
                else return _a;
            }
            set { _a = value; }
        }
        /// <summary>
        /// Устанавливает или возвращает сторону B
        /// </summary>
        public double B
        {
            get
            {
                if (_b < 0)
                {
                    throw new Exception("Сторона должна быть больше нуля");
                }
                else return _a;
            }
            set { _b = value; }
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
