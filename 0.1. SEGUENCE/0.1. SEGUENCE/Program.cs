using System;

namespace _0._1._SEQUENCE
{
    class Program
    {
        public static void Sequence(int n) {
            if (n == 1)
            {
                Console.Write("{0}", n);
            }
            else
            {
                
                Sequence(n - 1);
                Console.Write(", {0}", n);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write number");
            int n;
            Start:
            Console.Write("N = ");
            bool success = Int32.TryParse(Console.ReadLine(), out n);
            if (success && n>0 && (n % 1.0 == 0))
            {
                Sequence(n);
            }
            else
            {
                Console.WriteLine("Try again");
                goto Start;
            }
        }
    }
}
