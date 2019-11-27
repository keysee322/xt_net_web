using System;

namespace _2._2.TRIANGLE
{
       class Triangle
    {
        public double A;
        public double B;
        public double C;

        public Triangle (double a, double b, double c)
        {   

            A = a;
            B = b;
            C = c;
        }
        public Triangle()
        {
            A = 0;
            B = 0;
            C = 0;
        }
        public double a
        {
            get
            {
                return A;
            }
            set
            {
                if (value > 0)
                    A = value;
            }
        }
        public double b
        {
            get
            {
                return B;
            }
            set
            {
                if (value > 0)
                    B = value;
            }
        }
        public double c
        {
            get
            {
                return C;
            }
            set
            {
                if (value > 0)
                    C = value;
            }
        }
        public double getArea 
        {
            get
            {
                return 0;
            }
        }
        public double getPerimert
        {
            get
            {
                return A + B + C;
            }
        }
        public bool triangleExist
        {
            get
            {
                if (A < (B * C) && B < (A * C) && C < (A * B))
                    return true;
                else return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle a1 = new Triangle();
            Console.Write("A = ");
            a1.A = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            a1.B = double.Parse(Console.ReadLine());
            Console.Write("C = ");
            a1.C = double.Parse(Console.ReadLine());
            if (a1.triangleExist)
            {
                Console.WriteLine("Area of triangle is {0}", a1.getArea);
                Console.WriteLine("Perimetr of triangle is {0}", a1.getPerimert);
            }
            else { Console.WriteLine("Your triangle don't exist =(");
            }
        }
    }
}
