using System;

namespace _1._8._NO_POSITIVE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, z; // длина, ширина, глубина 
        Start:
            Console.Write("n = ");
            bool success = int.TryParse(Console.ReadLine(), out n);
            Console.Write("m = ");
            bool success1 = int.TryParse(Console.ReadLine(), out m);
            Console.Write("z = ");
            bool success2 = int.TryParse(Console.ReadLine(), out z);

            if (success && success1 && success2)
            {
                goto Finish;
            }
            else
            {
                Console.WriteLine("Try again");
                goto Start;
            }
        Finish:
            int[,,] array = new int[n, m, z];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    for (int k=0; k<z; k++)
                {
                    Console.Write("array[{0},{1},{2}] = ", i, j, k);
                    array[i, j, k] = int.Parse(Console.ReadLine());
                }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    for (int k = 0; k < z; k++)
                    {
                        if (array[i, j, k] > 0)

                            array[i, j, k] = 0;
                        Console.WriteLine("array[{0},{1},{2}] = {3}", i, j, k, array[i, j, k]);
                    }
        }
    }
}