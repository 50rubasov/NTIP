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
        [DllImport("msvcrt")]
        static extern char _getch();

        static void Main(string[] args)
        {
            char key;
            int AsciiValue = 0;           

            while (AsciiValue != 27)
            {
                Console.Clear();
                Console.WriteLine("1 - Площадь треугольника.");
                Console.WriteLine("2 - Площадь круга.");
                Console.WriteLine("3 - Площадь прямоугольника.");
                Console.WriteLine("Esc - Выход. \n");

                key = _getch();
                AsciiValue = key;

                switch (AsciiValue)
                {                 
                    case '1':
                        Triangle triangle = new Triangle(3.0, 4.0, 5.0);
                        Console.Write("Площадь треугольника: " + triangle.Area());
                        Console.ReadKey();
                        break;
                    case '2':
                        Circle circle = new Circle(2.0);
                        Console.Write("Площадь круга: " + circle.Area());
                        Console.ReadKey();
                        break;
                    case '3':
                        Rectangle rectangle = new Rectangle(2.0, 3.0);
                        Console.Write("Площадь прямоугольника: " + rectangle.Area());
                        Console.ReadKey();
                        break;
                }

            }
        }
    }
}
