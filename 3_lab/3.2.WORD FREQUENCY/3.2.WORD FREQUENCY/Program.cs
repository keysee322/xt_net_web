using System;
using System.Collections;

namespace Edinstvennoe_slovo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Hashtable openWith = new Hashtable();

            string s; string[] str;
            Console.WriteLine("Введите строку");
            s = Console.ReadLine();
            str = s.Split(' ', '.');
            while (i < str.Length)
            {
                
                try
                {
                    openWith.Add(str[i].ToLower(), 0);
                }
                catch
                {
                    openWith[str[i]] = 0;
                }
                i++;
            }
            string[] mas = new string[openWith.Count];
            int[] mas1 = new int[openWith.Count];
            for (i = 0; i < openWith.Count; i++)
            {
                mas[i] = str[i];
                mas1[i] = 0;
            }
            for (i = 0; i<mas.Length; i++)
                for (int j = 0; j < str.Length; j++)
                {
                    if (String.Equals(mas[i].ToLower(),str[j].ToLower()))
                    {
                        mas1[i]++;
                    }
                }
            for (i = 0; i<mas.Length;i++)
                Console.WriteLine("Word {0} contains {1} times", mas[i], mas1[i]);
        }
    }
}