using System;

namespace _0._2.SIMPLE
{
    class Program
    {
        public static void IsSimple(int n)
        {
            int i = 2;
            while (i < Math.Sqrt(n) && n % i != 0) {
                i++;
            }
            if (n % i ==0 && n!=2 || n==1)
            {
                Console.WriteLine("Number isn't simple");
            } else
            {
                Console.WriteLine("Number is simple");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write number");
            int n;
        Start:
            Console.Write("N = ");
            bool success = Int32.TryParse(Console.ReadLine(), out n);
            if (success && n > 0 && (n%1.0 == 0))
            {
                IsSimple(n);
            }
            else
            {
                Console.WriteLine("Try again");
                goto Start;
            }
        }
    }
}
