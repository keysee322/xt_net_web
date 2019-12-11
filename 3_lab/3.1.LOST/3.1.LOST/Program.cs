using System;
using System.Collections.Generic;

namespace _3._1.LOST
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            List<string> human = new List<string>();
            for (int j = 0; j < n; j++)
            {
                human.Add(Console.ReadLine());
            }

            int i = 1;
            while (human.Count > 1)
            {
                
                for (; i < human.Count; i++)
                {
                    human.RemoveAt(i);
                    Console.WriteLine();
                    for (int j = 0; j < human.Count; j++)
                        Console.Write("{0} ", human[j]);
                }
                if (human.Count % 2 == 0)
                    i = 1;
                else i = 0;
            }
        }
        }
    }

