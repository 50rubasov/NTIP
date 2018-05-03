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
                try
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
                            {
                                Console.WriteLine("Введите координату A:");
                                double a = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите координату B:");
                                double b = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите координату C:");
                                double c = Convert.ToDouble(Console.ReadLine());

                                IFigure triangle = new Triangle(a, b, c);

                                Console.Write("Площадь треугольника: " + triangle.Area());
                                Console.ReadKey();
                                break;
                            }
                        case '2':
                            {
                                Console.WriteLine("Введите радиус:");
                                double R = Convert.ToDouble(Console.ReadLine());

                                IFigure circle = new Circle(R);
                                Console.Write("Площадь круга: " + circle.Area());
                                Console.ReadKey();
                                break;
                            }
                        case '3':
                            {
                                Console.WriteLine("Введите длинну:");
                                double a = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Введите ширину:");
                                double b = Convert.ToDouble(Console.ReadLine());

                                Rectangle rectangle = new Rectangle(a, b);
                                Console.Write("Площадь прямоугольника: " + rectangle.Area());
                                Console.ReadKey();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Некорректное значение");
                                Console.ReadKey();
                                break;
                            }
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Несоответсвие типа");
                    Console.ReadKey();
                }
            }
        }
    }
}
