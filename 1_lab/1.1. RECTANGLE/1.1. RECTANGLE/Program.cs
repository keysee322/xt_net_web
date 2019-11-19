using System;

namespace _1._1._RECTANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number");
            int a,b;
        Start:
            Console.Write("a = ");

            bool success = Int32.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            bool success1 = Int32.TryParse(Console.ReadLine(), out b);
            if (success && success1 && a > 0 && b>0)
            {
                Console.WriteLine("S = {0}", a * b);
            }
            else
            {
                Console.WriteLine("Try again");
                goto Start;
            }
        }
    }
}

