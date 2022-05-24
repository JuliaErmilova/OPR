using System;

namespace ProgB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите c:");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) & (a > c))
            {
                Console.Write("Самое большое число a={0}",a);
            }
            else if ((b > a) & (b > c))
            {
                Console.Write("Самое большое число b={0}", b);
            }
            else if ((c > a) & (c > b))
            {
                Console.Write("Самое большое число c={0}", c);
            }
        }
    }
}
