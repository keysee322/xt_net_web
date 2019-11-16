using System;

namespace _0._4.ARRAY
{
    class Program
    {
        public static void Sequence(int n)
        {
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
            if (success && n > 0)
            {
                goto StartProgram;
            }
            else
            {
                Console.WriteLine("Try again");
                goto Start;
            }


        StartProgram:
            int[][] array = new int[n][];
            int size;
            Random rnd = new Random();
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Input {0} array size", i);
                size = int.Parse(Console.ReadLine());
                array[i] = new int[size];
                for (int j=0; j < size; j++)
                {
                    array[i][j] = rnd.Next(0, 100);
                }
            }
            Console.WriteLine("Source array:");

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                    Console.WriteLine("\t array[{0}][{1}] = {2}", i, j, array[i][j]);
                Console.WriteLine();
            }

            Console.WriteLine("Sorted array:");

            int temp;
            for (int k = 0; k<n; k++)
            for (int i = 0; i < array[k].Length - 1; i++)
            {
                for (int j = i + 1; j < array[k].Length; j++)
                {
                    if (array[k][i] > array[k][j])
                    {
                        temp = array[k][i];
                        array[k][i] = array[k][j];
                        array[k][j] = temp;
                    }
                }
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                    Console.WriteLine("\t array[{0}][{1}] = {2}", i, j, array[i][j]);
                Console.WriteLine();
            }
        }
    }
}
