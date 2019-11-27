using System;

namespace _2._3.USER
{
    public class User
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Birthday { get; set; }
        public int Age { get; set; }

        public void getInformation() {
            Console.WriteLine("Name of user is {0}, his surname is {1}, and patronymic is {2}, he was born in {3}, and now he is {4} years old", Name, Surname, Patronymic, Birthday, Age);
        }

        public User() { }



    }
    class Program
    {
        static void Main(string[] args)
        {
            User a1 = new User();
            Console.Write("Name of user is ");
            a1.Name = Console.ReadLine();
            Console.Write("Surname of user is ");
            a1.Surname = Console.ReadLine();
            Console.Write("Patronymic of user is ");
            a1.Patronymic = Console.ReadLine();
            Console.Write("Birthday of user is ");
            a1.Birthday = Console.ReadLine();
            Console.Write("Age of user is ");
            a1.Age = int.Parse(Console.ReadLine());
            a1.getInformation();
        }
    }
}
