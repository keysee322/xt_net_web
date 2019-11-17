using System;
using System.Collections.Generic;

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
            List<int> numbers = new List<int> {};
            int size;
            Random rnd = new Random();
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Input {0} array size", i);
                size = int.Parse(Console.ReadLine());
                array[i] = new int[size];
                for (int j=0; j < size; j++) // одновременно заполняется массив и значения переносятся в List, для последующей сортировки там
                {
                    array[i][j] = rnd.Next(0, 100);
                    numbers.Add(array[i][j]);       
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

            int temp; // сортировка List
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }


            int k=0; //индекс по общему кол-ву эл-ов
            for (int i = 0; i < n; i++) //Заносятся отсортированные значения из List в массив
            {
                for (int j = 0; j < array[i].Length; j++)
                {   
                    array[i][j] = numbers[k];
                    k++;
                }

            }


            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                    Console.WriteLine("\t array[{0}][{1}] = {2}", i, j, array[i][j]);
                Console.WriteLine();
            }
            Console.WriteLine(array.Length);
        }
    }
}
