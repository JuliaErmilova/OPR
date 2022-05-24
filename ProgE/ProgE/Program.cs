using System;

namespace ProgE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = 0;
            int b = 0;
            while (A[b] % 2 == 1)
            {
                k = k + A[b];
                b = b + 1;
            }
            Console.WriteLine("Сумма нечётных числе в начале равна:{0}",k);
        }
    }
}
