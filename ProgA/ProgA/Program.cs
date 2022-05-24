using System;

namespace ProgA
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
            double V;
            V = (a * b * c) * 0.21;
            Console.WriteLine("V={0}",V);
        }
    }
}
