using System;

namespace Prog8
{
    class Program
    {
        static float Gen(int a, int b)
        {
            Random rand = new Random();

            return rand.Next(a + 1, b - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i} - {Gen(a, b)};");
            }
        }
    }
}
