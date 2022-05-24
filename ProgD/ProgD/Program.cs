using System;

namespace ProgD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string n = Console.ReadLine();
            string n1 = "";
            for (int i = n.Length - 1; i >= 0; i--)
            {
                n1 += n[i];
            }
            Console.WriteLine("Число перевёртыш: " + n1);
        }
    }
}
