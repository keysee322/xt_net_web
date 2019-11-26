using System;

namespace _2._1.ROUND
{
    class Round
    {
        public double X;
        public double Y;
        public double Radius;
        public const double PI = 3.14159;
        public Round()
        {
            Radius = 0;
            X = 0;
            Y = 0;
        }
        public Round(double x, double y, double r)
        {
            Radius = r;
            this.X = x;
            this.Y = y;
        }
        public double getArea
        {
            get
            {
                return PI * Radius * Radius;
            }
        } 
        public double getLength
        {
            get
            {
                return 2 * PI * Radius;
            }
        }
        public double radius
        {
            get
            {
                return Radius;
            }

            set
            {
                // ensure non-negative radius value 
                if (value >= 0)
                    Radius = value;
            }
        }
        public double x
        {
            get
            {
                return X;
            }

            set
            {
                    X = value;
            }
        }
        public double y
        {
            get
            {
                return Y;
            }

            set
            {
                Y = value;
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Round a1 = new Round();
            Console.Write("X = ");
            a1.X = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            a1.Y = double.Parse(Console.ReadLine());
            Console.Write("Radius = ");
            a1.radius = double.Parse(Console.ReadLine());
            Console.Write("Round area = {0}", a1.getArea);
            Console.WriteLine("\nRound length = {0}", a1.getLength);
        }
    }
}
