using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
            static void Main(string[] args)
            {
                try
                {
                    Console.Write("Введите радиус окружности R = ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    if (r > 0)
                    {
                        Console.Write("Введите координату центра круга х0 = ");
                        double x0 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите координату центра круга y0 = ");
                        double y0 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите координату точки х = ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите координату точки y = ");
                        double y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Длина окружности = {0}", Circle.CalcLength(r));
                        Console.WriteLine("Площадь окружности = {0}", Circle.CalcSquare(r));
                        Circle.Affiliation(r, x0, y0, x, y);
                    }
                    else
                    {
                        Console.WriteLine("Радиус не может быть меньше либо равен 0");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Для завершения нажмите любую клавишу");
                    Console.ReadKey();
                }
            }
        }
        public static class Circle
        {
            public static double CalcLength(double r)
            {
                double length = Math.Round((2 * Math.PI * r), 2);
                return length;
            }
            public static double CalcSquare(double r)
            {
                double square = Math.Round((Math.PI * Math.Pow(r, 2)), 2);
                return square;
            }
            public static bool Affiliation(double r, double x0, double y0, double x, double y)
            {
                bool check;
                if (Math.Pow((x - x0), 2) + (Math.Pow((y - y0), 2)) <= Math.Pow(r, 2))
                {
                    Console.WriteLine("Точка находится внутри круга");
                    check = true;
                    return check;
                }
                else
                {
                    Console.WriteLine("Точка находится за пределами круга");
                    check = false;
                    return check;
                }
            }
        }
    }