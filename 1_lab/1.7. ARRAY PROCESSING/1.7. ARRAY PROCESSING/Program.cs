using System;

namespace _1._7._ARRAY_PROCESSING
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random rnd = new Random();
            int max = 0; int min = 100;
        Start:
            Console.Write("N = ");// проще задатать размерность массива руками, чем использовать фиксированное число
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
            for (int i=0; i<n; i++)
            {
                array[i] = rnd.Next(0, 100);
            }

            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            //т.к. массив сортирован по возрастанию
            min = array[0];
            max = array[array.Length-1];
            


            for (int i = 0; i < n; i++)
                Console.WriteLine("array[{0}]= {1}", i, array[i]);
            Console.WriteLine("min = {0}, max = {1}", min, max);
        }
    }
}
