using System;

namespace ProgC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];            
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int first = 0;
            int last = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % a[0] == 0) first = first + 1;
                else if (a[i] % a[n-1] == 0) last = last + 1;
            }
            if (last> first) Console.Write("Больше элементов делится на последний элемент массива");
            else Console.Write("Больше элементов делится на первый элемент массива");
        }
    }
}
