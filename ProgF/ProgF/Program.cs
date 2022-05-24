using System;

namespace ProgF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for (int i = a; i <= b; i++)
            {
                if(i > 0)
                {
                    if(i % 4==0)
                    {
                        sum = sum + i;
                    }
                }
            }
            Console.Write("Сумма чисел равна:{0}",sum);
        }
    }
}
