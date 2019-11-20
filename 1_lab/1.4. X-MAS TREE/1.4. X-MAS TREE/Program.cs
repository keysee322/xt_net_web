using System;

namespace _1._4._X_MAS_TREE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number");
            int n;
        Start:
            Console.Write("N = ");
            bool success = Int32.TryParse(Console.ReadLine(), out n);
            if (success && n > 0 && (n % 1.0 == 0))
            {for (int k=1;k<=n;k++)
                for (int i = 1; i <= k; i++)
                {
                    for (int j = 1; j < n * 2; j++)
                        if (j <= n - i || j >= n + i)
                            Console.Write(" ");
                        else
                            Console.Write("*");
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Try again");
                goto Start;
            }
        }
    }
}

