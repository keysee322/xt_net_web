using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._4.MY_STRING
{
        public class Mystring
        {
            private char[] ch;
        public string s { get; set; }
            public char this[int i]
            {
                set
                {
                    ch[i] = value;
                }
                get
                {
                    return ch[i];
                }

            }
            public Mystring(char[] str)
            {
                this.ch = str;
            }
            public Mystring()
            {
                ch = new char[0];
            }
            public char[] ToArray()
            {
                return ch;
            }
            public static Mystring Сombine (Mystring s1, Mystring s2)
            {
                List<char> l = new List<char>();
                l.AddRange(s1.ToArray());
                l.AddRange(s2.ToArray());
                return new Mystring(l.ToArray());
            }
            public static bool Different (Mystring s1, Mystring s2)
            {
                return s1.GetHashCode() != s2.GetHashCode();
            }
            public static bool Equal(Mystring s1, Mystring s2)
            {
                return !(s1 != s2);
            }
           
            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            public override string ToString()
            {
                string s = "";
                foreach (var a in ch)
                {
                    s += a;
                }
                return s;
            }
        public char[] ToChar()
        {
            char[] q = s.ToCharArray();
            return q;
        }
        public int Search(char a)
            {
                if (ch.Contains(a))
                {
                    return Array.IndexOf(ch, a);
                }
                else
                {return 0;}
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Mystring s1 = new Mystring(new char[] { 'a', 'b', 'c', 'd', 'e' });
            Mystring s2 = new Mystring(new char[] { 'f', 'g', 'h', 'i', 'h' });
            Console.WriteLine((Mystring.Сombine(s1, s2)).ToString());
            Console.WriteLine((Mystring.Equal(s1,s2)).ToString());
            Console.WriteLine((Mystring.Different(s1,s2)).ToString());
            Console.WriteLine((s2.Search('h').ToString()));
            Console.WriteLine(s2.ToString());
            Console.WriteLine(s2.ToChar());
        }
    }
}
    