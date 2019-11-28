using System;

namespace _2._6.RING
{
    class Round
    {
        public double X;
        public double Y;
        public virtual double Radius { get; set; }
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
        public virtual double getArea()
        {
                return PI * Radius * Radius;
        }
        public virtual double getLength()
        {
                return 2 * PI * Radius;
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
    
    class Ring : Round
    {
        public override double Radius { get; set; }
        public override double getArea() {
            return PI*Radius*Radius - PI*base.Radius*base.Radius;
        }
        public override double getLength()
        {
            return 2 * PI * Radius;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Ring a1 = new Ring();
            Console.Write("X = ");
            a1.X = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            a1.Y = double.Parse(Console.ReadLine());
            Console.Write("Radius inside = ");
            a1.Radius = double.Parse(Console.ReadLine());
            Console.Write("Radius outside = ");
            ((Ring)a1).Radius = double.Parse(Console.ReadLine());
            Console.Write("Ring area = {0}", ((Ring)a1).getArea());
            Console.WriteLine("\nRound length = {0}", ((Ring)a1).getLength());
        }
    }
}
