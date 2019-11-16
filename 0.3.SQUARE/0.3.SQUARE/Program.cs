using System;

namespace _0._3.SQUARE
{
    class Program
    {
        public static void Square(int n)
        { int midpoint=n/2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && i == midpoint)
                        Console.Write(" ");
                    else Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write number");
            int n;
        Start:
            Console.Write("N = ");
            bool success = Int32.TryParse(Console.ReadLine(), out n);
            if (success && n > 0 && (n % 2 == 1))
            {
                Square(n);
            }
            else
            {
                Console.WriteLine("Try again");
                goto Start;
            }
        }
    }
}