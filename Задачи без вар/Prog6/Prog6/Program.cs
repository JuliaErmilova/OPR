using System;

namespace Prog6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Площадь S: ");
            double s = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            for (int a = 1; a < s; a++)
            {
                for (int b = 1; b < s; b++)
                {
                    for (int c = 1; c < s; c++)
                    {
                        double a2 = Math.Pow(a, 2);
                        double b2 = Math.Pow(b, 2);
                        double c2 = Math.Pow(c, 2);

                        if (a2 + b2 == c2)
                        {
                            double x = (a2 + 2 * a * b + b2 - c2) / 4;

                            if (x <= s)
                            {
                                Console.WriteLine($"a = {a}, b = {b}, c = {c}, S = {x}");
                                count += 1;
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Таких треугольников не существует.");
            }
        }
    }
}
