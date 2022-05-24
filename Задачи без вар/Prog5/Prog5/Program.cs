using System;

namespace Prog5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Random rand = new Random();

            while (a[0] == 1 || a[1] == 2 || a[2] == 3 || a[3] == 4 || a[4] == 5 || 
                a[5] == 6 || a[6] == 7 || a[7] == 8 || a[8] == 9 || a[9] == 10)
            {
                for (int i = 0; i <= 9; i++)
                {
                    int x = rand.Next(i + 1);
                    int temp = a[i];
                    a[i] = a[x];
                    a[x] = temp;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{a[i]}");
            }
        }
    }
}
