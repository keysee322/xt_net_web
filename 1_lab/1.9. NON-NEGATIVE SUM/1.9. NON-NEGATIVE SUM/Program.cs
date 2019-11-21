using System;

namespace _1._9._NON_NEGATIVE_SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int sum = 0;
            Console.Write("N= ");
            Start:
            bool success = Int32.TryParse(Console.ReadLine(), out n);
            if (success && n > 0)
            {
                goto Finish;
            }
            else
            {
                Console.WriteLine("Try again");
                goto Start;
            }
            Finish:
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}]= ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
                if (array[i] < 0) sum += array[i];
            Console.WriteLine("Negarive sum = {0}", sum);
        }
    }
}
