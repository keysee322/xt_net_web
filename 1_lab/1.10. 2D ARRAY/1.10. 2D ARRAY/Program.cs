using System;

namespace _1._10._2D_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m; int sum = 0;
        Start:
            Console.Write("n = ");
            bool success = int.TryParse(Console.ReadLine(), out n);
            Console.Write("m = ");
            bool success1 = int.TryParse(Console.ReadLine(), out m);
            
            if (success && success1)
            {
                goto Finish;
            } else
            {
                Console.WriteLine("Try again");
                goto Start;
            }
            Finish:
            int[,] array = new int[n,m];
            for (int i=0; i<n;i++)
                for (int j=0; j < m; j++)
                {
                    Console.Write("array[{0},{1}] = ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if ((i + j) % 2 == 0)
                        sum += array[i, j];
            Console.WriteLine("sum = {0}", sum);
        }
    }
}
