using System;

namespace Prog4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество попыток: ");
            int k = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int n = rand.Next(1, 11);

            while (k > 0)
            {
                Console.Write("Введите ваше число: ");
                int x = int.Parse(Console.ReadLine());

                if (x < n)
                {
                    k -= 1;
                    if (k == 0)
                    {
                        Console.WriteLine("Попытки закончились(");
                        break;
                    }
                    Console.WriteLine("Больше");
                }
                if (x > n)
                {
                    k -= 1;
                    if (k == 0)
                    {
                        Console.WriteLine("Попытки закончились(");
                        break;
                    }
                    Console.WriteLine("Меньше");

                }

                if (x == n)
                {
                    Console.WriteLine("Вы угадали!!!");
                    break;
                }
            }
        }
    }
}
