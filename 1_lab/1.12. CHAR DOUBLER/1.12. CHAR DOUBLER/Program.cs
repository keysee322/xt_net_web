using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstString = "";
            string SecondString = "";
            string FinalString = "";
            Console.WriteLine("Введи первую строку");
            FirstString = Console.ReadLine();
            Console.WriteLine("Введи вторую строку");
            SecondString = Console.ReadLine();
            foreach (char ch in FirstString)
                if (SecondString.Contains(ch))
                {
                    FinalString += ch;
                    FinalString += ch;
                }
                else
                
                    FinalString += ch;
                
            Console.WriteLine("Результат = {0}", FinalString);
        }
    }
}