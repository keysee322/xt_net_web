using System;

namespace _2._5.EMPLOYEE
{
    public class User
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Birthday { get; set; }
        public string Age { get; set; }

        public void getInformation() {
            Console.WriteLine("Name of user is {0}, his surname is {1}, and patronymic is {2}, he was born in {3}, and now he is {4} years old", Name, Surname, Patronymic, Birthday, Age);
        }

        public User() {
            Surname = "Unknown";
            Name = "Unknown";
            Patronymic = "Unknown";
            Birthday = "Unknown";
            Age = "-";
        }



    }
    public class Employee : User
    {
        public string Stage { get; set; }
        public string Doljnost { get; set; }

        public void getEmployeeInformation()
        {
            getInformation();
            Console.WriteLine("He's working as a {0} for {1} years", Doljnost, Stage);
        }
        public Employee()
        {
            Stage = "Unknown";
            Doljnost = "Unknown";
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee a1 = new Employee();
            Console.Write("Name of user is ");
            a1.Name = Console.ReadLine();
            Console.Write("Surname of user is ");
            a1.Surname = Console.ReadLine();
            Console.Write("Patronymic of user is ");
            a1.Patronymic = Console.ReadLine();
            Console.Write("Birthday of user is ");
            a1.Birthday = Console.ReadLine();
            Console.Write("Age of user is ");
            a1.Age = Console.ReadLine();
            Console.Write("Doljnost' of user is ");
            a1.Doljnost = Console.ReadLine();
            Console.Write("User's stage is (in years)");
            a1.Stage = Console.ReadLine();
            a1.getEmployeeInformation();
        }
    }
}
