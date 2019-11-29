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

        class Round : Figure
        {
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

            public override void Info()
            {
                Console.WriteLine("Построен круг с центром в точке [{0},{1}] и R = ", X, Y, Radius);
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
            public override void Info()
            {
                Console.WriteLine("Построено кольцо с центром в точке [{0},{1}], с внешним R = {2} и внутренним r = {3}", X, Y, Radius, base.Radius);
            }
            public override double Radius { get; set; }
            public override double getArea()
            {
                return PI * Radius * Radius - PI * base.Radius * base.Radius;
            }
            public override double getLength()
            {
                return 2 * PI * Radius;
            }
        }

        class Triangle : Figure
        {
            public double X2 { get; set; }
            public double Y2 { get; set; }
            public double X3 { get; set; }
            public double Y3 { get; set; }

            public virtual double getLengthOfSideAB()
            {
                return Math.Abs(Math.Abs(X2 * X2 + Y2 + Y2) - Math.Abs(X * X + Y * Y));
            }

            public virtual double getLengthOfSideAC()
            {
                return Math.Abs(Math.Abs(X3 * X3 + Y3 + Y3) - Math.Abs(X * X + Y * Y));
            }

            public virtual double getLengthOfSideBC()
            {
                return Math.Abs(Math.Abs(X2 * X2 + Y2 + Y2) - Math.Abs(X3 * X3 + Y3 * Y3));
            }

            public Triangle()
            {
                X2 = 0;
                Y2 = 0;
                X3 = 0;
                Y3 = 0;
            }

            public override void Info()
            {
                Console.WriteLine("Построен треугольник со сторонами {0}, {1}, {2}", getLengthOfSideAB(), getLengthOfSideBC(), getLengthOfSideAC());
            }
            public double getArea
            {
                get
                {
                    return Math.Sqrt((getPerimert / 2) * (getPerimert - getLengthOfSideAB()) * (getPerimert - getLengthOfSideBC()) * (getPerimert - getLengthOfSideAC()));
                }
            }
            public double getPerimert
            {
                get
                {
                    return getLengthOfSideAB() + getLengthOfSideBC() + getLengthOfSideAC();
                }
            }
            public bool triangleExist
            {
                get
                {
                    if (getLengthOfSideAB() < (getLengthOfSideBC() * getLengthOfSideAC()) && getLengthOfSideBC() < (getLengthOfSideAB() * getLengthOfSideAC()) && getLengthOfSideAC() < (getLengthOfSideAB() * getLengthOfSideBC()))
                        return true;
                    else return false;
                }
            }
        }

        static void Main(string[] args)
        {
            Round a1 = new Round();
            Triangle a2 = new Triangle();
            Figure a3 = new Figure();
            Ring a4 = new Ring();
            a4.X = 0;
            a4.Y = 0;
            a4.Radius = 3;
            a4.Info();
            a4.getArea(); a4.getLength();

            a1.X = 0;
            a1.Y = 0;
            a1.Radius = 3;
            a1.Info();
            a1.getArea(); a1.getLength();

            a2.X = 0;
            a2.Y = 0;
            a2.X2 = 0;
            a2.Y2 = 0;
            a2.X3 = 0;
            a2.Y3 = 0;
            a2.Info();
            Console.WriteLine( "S = {0}",a2.getArea);
            Console.WriteLine( "P = {0}", a2.getPerimert );

        }
    }
}
