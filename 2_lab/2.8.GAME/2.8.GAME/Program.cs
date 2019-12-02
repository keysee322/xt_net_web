using System;

namespace _2._8.GAME
{
    class Pole
    {
        public int Width;
        public int Height;
        public Pole()
        {
            Width = 30;
            Height = 30;
        }
        public int width
        {
            get
            {
                return Width;
            }
            set
            {
                if (value > 0)
                    Width = value;
            }
        }
        public int height
        {
            get
            {
                return Height;
            }
            set
            {
                if (value > 0)
                    Height = value;
            }
        }
    }
    class Player : Pole
    {
        private int X;
        private int Y;
        public Player()
        {
            X = 0;
            Y = 0;
        }
        public int x
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
        public int y
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

        public void goLeft()
        {
            if (x > 0)
                x = x - 1;
        }
        public void goRight()
        {
            if (x < width)
                x = x + 1;
        }
        public void goUp()
        {
            if (y < height)
                y = y + 1;
        }
        public void goDown()
        {
            if (y > 0)
                y = y - 1;
        }
    }
    class Bonus : Pole
    {
        public int Xb;
        public int Yb;
        public int xb
        {
            get
            {
                return Xb;
            }
            set
            {
                if (value >= 0 && value <= width)
                    Xb = value;
            }

        }
        public int yb
        {
            get
            {
                return Yb;
            }
            set
            {
                if (value >= 0 && value <= height)
                    Yb = value;
            }
        }
        public Bonus()
        {
            Xb = 0;
            Yb = 0;
        }
        public virtual int getBonus(int n)
        {
            return n;
        }
    }

    class Apple : Bonus
    {
        public int getBonus(int n)
        {
            Console.WriteLine("You found an apple! Next monser you meet will not debaff you");
            return n++;
        }
    }
    class Cherry : Bonus
    {

        public int getBonus(int n)
        {
            Console.WriteLine("You found a cherry! Next monser you meet will not debaff you"); // типо +1 жизни
            return n++;
        }

    }

    class Monster : Pole
    {
        public int Xm;
        public int Ym;
        public Monster()
        {
            Xm = 0;
            Ym = 0;
        }
        public int xm
        {
            get
            {
                return Xm;
            }
            set
            {
                if (value > 0 && value < width)
                    Xm = value;
            }

        }
        public int ym
        {
            get
            {
                return Ym;
            }
            set
            {
                if (value > 0 && value < height)
                    Ym = value;
            }
        }
        public virtual int getMonster(int n)
        {
            return n;
        }
    }
    class Wolf : Monster
    {
        public override int getMonster(int n)
        {
            Console.WriteLine("Oh no, it's a WOLF! Run away (you go for one point DOWN)");
            return --n;
        }
    }
    class Bear : Monster
    {

        public override int getMonster(int n)
        {
            Console.WriteLine("Oh no, it's a BEAR! Hide and hold your breath(you stay one turn in your coordinates. Bear go to 1 point UP) ");
            xm++;
            return n++;
        }
    }

    class Obstacle : Pole
    {
        public int Xo;
        public int Yo;
        public Obstacle()
        {
            Xo = 0;
            Yo = 0;
        }
        public int xo
        {
            get
            {
                return Xo;
            }
            set
            {
                if (value >= 0 && value <= width)
                    Xo = value;
            }
        }
        public int yo
        {
            get
            {
                return Yo;
            }
            set
            {
                if (value >= 0 && value <= height)
                    Yo = value;
            }
        }
        public virtual void getStuck()
        {

        }
    }
    class Tree : Obstacle
    {
        public override void getStuck()
        {
            Console.WriteLine("It's a tree on your way, you can't go this direction");
        }
    }
    class Rock : Obstacle
    {
        public override void getStuck()
        {
            Console.WriteLine("It's a Rock on your way, you can't go this direction");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; int life = 0; // кол - во ходов / кол-во "жизней"
            string s;
            Player a = new Player(); // начинает с (0, 0)
            Wolf wolf = new Wolf();
            Bear bear = new Bear();
            Apple apple = new Apple();
            Cherry cherry = new Cherry();
            Tree tree = new Tree();
            Rock rock = new Rock();
            wolf.ym = 1;
            apple.xb = 1; apple.yb = 1;
            cherry.xb = 2; cherry.yb = 1;
            bear.xm = 3; bear.ym = 1;
            tree.xo = 4; tree.yo = 1;
            rock.xo = 5; rock.yo = 1;
            Console.WriteLine("You stay in (0, 0), press to move A - left, W - up, S - down, D - right");
            for (int i = 0; i < 30; i++)
            {
                s = Console.ReadLine();
                if (s == "w" || s == "W")
                {
                    if (((a.y + 1) == (tree.yo)) && ((a.x) == (tree.xo)))
                    {
                        tree.getStuck();
                    }
                    else if (((a.y + 1) == (rock.yo))&&((a.x) == (rock.xo)))
                    {
                        rock.getStuck();
                    }
                    else a.goUp();
                }
                if (s == "s" || s == "S")
                {
                    if (((a.y - 1) == (tree.yo))&& ((a.x) == (tree.xo)))
                    {
                        tree.getStuck();
                    }
                    else if (((a.y - 1) == (rock.yo))&&((a.x) == (rock.xo)))
                    {
                        rock.getStuck();
                    }
                    else a.goDown();
                }
                if (s == "a" || s == "A")
                {
                    if (((a.x - 1) == (tree.xo))&& ((a.y) == (tree.yo)))
                    {
                        tree.getStuck();
                    }
                    else if (((a.x - 1) == (rock.xo))&& ((a.y) == (rock.yo)))
                    {
                        rock.getStuck();
                    }
                    else a.goLeft();
                }
                if (s == "d" || s == "D")
                {
                    if (((a.x + 1) == (tree.xo))&& ((a.y) == (tree.yo)))
                    {
                        tree.getStuck();
                    }
                    else if (((a.x + 1) == (rock.xo))&&((a.x + 1) == (tree.xo)))
                    {
                        rock.getStuck();
                    }
                    else a.goRight();
                }
                if ((a.x == wolf.xm) && (a.y == wolf.ym) && life == 0)
                {
                    wolf.getMonster(a.y);
                }
                if ((a.x == bear.xm) && (a.y == bear.ym) && life == 0)
                {
                    bear.getMonster(n);
                }
                if ((a.x == cherry.xb) && (a.y == cherry.yb))
                {
                    cherry.getBonus(life);
                }
                if ((a.x == apple.xb) && (a.y == apple.yb))
                {
                    apple.getBonus(life);
                }
                n++;
                Console.WriteLine("You here - [{0},{1}] \n Game lasts for {2} turns, you have {3} debaff breakes", a.x, a.y, n, life);
            }
        }
    }
}