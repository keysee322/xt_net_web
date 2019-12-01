using System;

namespace _2._7
{
    class Program
    {   class Figure
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Figure() {
                X = 0;
                Y = 0;
}
            public virtual void Info()
            {
                
            }

            
        }

        class Line : Figure
        {
            public double X2 { get; set; }
            public double Y2 { get; set; }
            public virtual double getLengthOfSideAB()
            {
                return Math.Abs(Math.Sqrt((X - X2) * (X - X2) + (Y - Y2) * (Y - Y2)));
            }
            public Line()
            {
                X2 = 0;
                Y2 = 0;

            }
            public virtual double getPerimert()
            {
                return getLengthOfSideAB();
            }
            public override void Info()
            {
                Console.WriteLine("Построена линия между 2мя точками - [{0},{1}] и [{2},{3}], длина линии - {4}", X, Y, X2, Y2, getPerimert());
            }

        }

        class Circle : Figure
        {
            public const double PI = 3.14159;
            public double Radius;

            public Circle()
            {
                Radius = 0;
            }
            public virtual double radius
            {
                get
                {
                    return Radius;
                }
                set
                {
                    if (value > 0)
                    {
                        Radius = value;
                    }

                }
            }
            public virtual double getLength()
            {
                return 2 * PI * Radius;
            }
            public override void Info()
            {
                Console.WriteLine("Построена окружность с центром в точке [{0},{1}] и R = {2}, длина окружности равна {3}", X, Y, Radius, getLength());
            }
        }

        class Round : Circle
        {
            
            public Round() 
            {
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
            

            public override void Info()
            {
                Console.WriteLine("Построен круг с центром в точке [{0},{1}] и R = {2}, длина окружности равна {3}, S = {4}", X, Y, Radius, getLength(), getArea());
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

        class Ring : Circle
        {
            public double Radius1;
            public Ring()
            {
                Radius1 = 0;
            }   
            public override void Info()
            {
                Console.WriteLine("Построено кольцо с центром в точке [{0},{1}],c внутренним r = {3} и внешним R = {2}, длина внутренней окружности равна {3}, длина внешней - {4}, S = {5}", X, Y, radius1, radius, base.getLength(), getLength(), getArea());
            }
            public override double radius // внешний радиус
            {
                get
                {
                    return Radius;
                }
                set
                {
                    if (value > base.radius)
                    {
                        Radius = value;
                    }
                }
            }
            public double radius1 // внешний радиус
            {
                get
                {
                    return Radius1;
                }
                set
                {
                    if (value > radius)
                    {
                        Radius1 = value;
                    }
                }
            }
            public double getArea()
            {
                return PI * Radius * Radius - PI * base.Radius * base.Radius;
            }

        }

        class Rectangle :Line
        {
            public double X3 { get; set; }
            public double Y3 { get; set; }
            public double X4 { get; set; }
            public double Y4 { get; set; }
            public Rectangle()
            {
                X3 = 0;
                Y3 = 0;
                X4 = 0;
                Y4 = 0;
            }
            public override void Info()
            {
                Console.WriteLine("Построен прямоугольник со стороной a = {0} и b = {1}, P = {2}, S = {3}", getLengthOfSideAB(), getLengthOfSideDA(), getPerimert(), getArea());
            }
            public bool IsRectangle()
            {
                if (((Math.Abs(X - X2) == Math.Abs(X3 - X4)) && (Math.Abs(Y - Y2) == Math.Abs(Y3 - Y4))) &&// Грубо говоря, идет проверка параллельности и равности линий
                    ((X3 - X) / (X2 - X) != (Y3 - Y) / (Y2 - Y)))
                    return true;
                else return false;
            }


            public virtual double getLengthOfSideBC()
            {
                return Math.Abs(Math.Sqrt((X3-X2) * (X3 - X2) + (Y3 - Y2) * (Y3-Y2)));
            }
            public virtual double getLengthOfSideCD()
            {
                return Math.Abs(Math.Sqrt((X4-X3) * (X4-X3) + (Y4-Y3) * (Y4-Y3)));
            }
            public virtual double getLengthOfSideDA()
            {
                return Math.Abs(Math.Sqrt((X4 - X) * (X4 - X) + (Y4 - Y) * (Y4 - Y)));
            }
            public override double getPerimert()
            {
                return getLengthOfSideAB() + getLengthOfSideBC() + getLengthOfSideCD() + getLengthOfSideDA();
            }
            public double getArea()
            {
                return getLengthOfSideAB() * getLengthOfSideBC();
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("What figure do you want to draw? \n 1. Line \n 2. Circle \n 3. Round \n 4. Ring \n 5. Rectangle");
            int s = int.Parse(Console.ReadLine());
            if (s == 1)
            {
                Line a1 = new Line();
                Console.Write("X = ");
                a1.X = double.Parse(Console.ReadLine());
                Console.Write("Y = ");
                a1.Y = double.Parse(Console.ReadLine());
                Console.Write("X2 = ");
                a1.X2 = double.Parse(Console.ReadLine());
                Console.Write("Y2 = ");
                a1.Y2 = double.Parse(Console.ReadLine());
                a1.Info();
            }
            else if (s == 2)
            {
                Circle a1 = new Circle();
                Console.Write("X = ");
                a1.X = double.Parse(Console.ReadLine());
                Console.Write("Y = ");
                a1.Y = double.Parse(Console.ReadLine());
                Console.Write("Radius = ");
                a1.Radius = double.Parse(Console.ReadLine());
                a1.Info();
            }
            else if (s == 3)
            {
                Round a1 = new Round();
                Console.Write("X = ");
                a1.X = double.Parse(Console.ReadLine());
                Console.Write("Y = ");
                a1.Y = double.Parse(Console.ReadLine());
                Console.Write("Radius = ");
                a1.Radius = double.Parse(Console.ReadLine());
                a1.Info();
            }
            else if (s == 4)
            {
                Ring a1 = new Ring();
                Console.Write("X = ");
                a1.X = double.Parse(Console.ReadLine());
                Console.Write("Y = ");
                a1.Y = double.Parse(Console.ReadLine());
                Console.Write("Small radius = ");
                a1.radius = double.Parse(Console.ReadLine());
                Console.Write("Big radius = ");
                a1.radius1 = double.Parse(Console.ReadLine());
                a1.Info();
            }
            else if (s == 5)
            {
                Rectangle a1 = new Rectangle();
                Console.Write("X = ");
                a1.X = double.Parse(Console.ReadLine());
                Console.Write("Y = ");
                a1.Y = double.Parse(Console.ReadLine());
                Console.Write("X2 = ");
                a1.X2 = double.Parse(Console.ReadLine());
                Console.Write("Y2 = ");
                a1.Y2 = double.Parse(Console.ReadLine());
                Console.Write("X3 = ");
                a1.X3 = double.Parse(Console.ReadLine());
                Console.Write("Y3 = ");
                a1.Y3 = double.Parse(Console.ReadLine());
                Console.Write("X4 = ");
                a1.X4 = double.Parse(Console.ReadLine());
                Console.Write("Y4 = ");
                a1.Y4 = double.Parse(Console.ReadLine());
                if (a1.IsRectangle()) 
                    a1.Info();
            else Console.WriteLine("Вы ввели неверные точки, невозможно построить прямоугольник"); 
            }
        }
    }
}
