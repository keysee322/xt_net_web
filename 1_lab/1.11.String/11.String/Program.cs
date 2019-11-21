using System;
using System.Text;

namespace _11.String
{
    class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your phrase:");
            string s = Console.ReadLine();
            var sb = new StringBuilder();
            double sum = 0;
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            s = sb.ToString();
            string[] splitted = s.Split(new[] { ' ' });
            for (int i = 0; i< splitted.Length; i++)
            {
                sum += splitted.Length;
            }
            Console.WriteLine("Average length of word is {0}", sum / splitted.Length);
            
        }
    }
}
