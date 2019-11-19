using System;

namespace _1._5._SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        { int n=0;
            for (int i = 0; i < 1000; i++)
                if (i % 5 == 0 || i % 3 == 0)
                    n += i;
            Console.WriteLine("{0}", n);
        }
    }
}
