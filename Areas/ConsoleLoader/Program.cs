using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Areas;

namespace ConsoleLoader
{
    class Program
    {
        /// <summary>
        /// Метод для демонстрации бизнес-логики
        /// </summary>
        /// <returns></returns>

        static void Main(string[] args)
        {
            double a = 2.0, b = 3.0, h = 6.0, R = 5;
            IFigure triangle = new Triangle(a, h);

            Console.WriteLine("Площадь треугольника: " + triangle.Area());

            IFigure circle = new Circle(R);
            Console.WriteLine("Площадь круга: " + circle.Area());


            Rectangle rectangle = new Rectangle(a, b);
            Console.WriteLine("Площадь прямоугольника: " + rectangle.Area());

            Console.ReadKey();

        }
    }
}