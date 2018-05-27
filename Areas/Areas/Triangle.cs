﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    /// <summary>
    /// Плозадь треугольника
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// сторона А
        /// </summary>
        private double _a;
        /// <summary>
        /// высота
        /// </summary>
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
            get
            {
                if (_a < 0)
                {
                    throw new Exception("Основание должно быть больше нуля");
                }
                else return _a;
            }
            set { _a = value; }
        }
        /// <summary>
        /// Установить или возвратить высоту
        /// </summary>
        public double H
        {
            get
            {
                if (_h < 0)
                {
                    throw new Exception("Высота должна быть больше нуля");
                }
                else return _h;
            }

            set { _h = value; }

        }
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>площадь</returns>
        public double Area()
        {                     
            return 0.5*A*H;
        }
    }
}
