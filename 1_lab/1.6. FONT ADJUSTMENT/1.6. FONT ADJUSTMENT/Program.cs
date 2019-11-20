using System;

namespace _1._6._FONT_ADJUSTMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; // счетчик для слов, чтобы понять, ставить запятую или нет
            int number; // число, которое вводит пользователь
            bool work = true; // чтобы можно было выйти из цикла при нажатии 4;

            // булеан для того чтобы реализовать добавление/ удаление информации о форматировании текста при нажатии одной кнопки

            bool a_bool = false; // кнопка 1
            bool b_bool = false; // кнопка 2
            bool c_bool = false; // кнопка 3
            while (work) {
                n = 0;
                Console.Write("Параметры надписи:");
              
                
                if (a_bool) {
                    if (n > 0)
                    {
                        Console.Write(", ");
                        n--;
                    }
                    Console.Write("Bold");
                    n++;
                }
               


                
                if (b_bool)
                {
                    if (n > 0)
                    {
                        Console.Write(", ");
                        n--;
                    }
                    Console.Write("Italic");
                    n++;
                }

              

                if (c_bool)
                {
                    if (n > 0)
                    {
                        Console.Write(", ");
                        n--;
                    }
                    Console.Write("Underline");
                    n++;
                }
                

                if (!a_bool && !b_bool && !c_bool) {
                    Console.Write("None");
                    n = 0;
                }
                Console.WriteLine();

                Console.WriteLine("Введите:\n1: bold\n2: italic\n3: underline\n4: exit");
                number = int.Parse(Console.ReadLine());
                if (number == 1)
                {
                    a_bool = !a_bool;
                } else
                if (number == 2)
                {
                    b_bool = !b_bool;
                } else
                if (number == 3)
                {
                    c_bool = !c_bool;
                } else
                if (number == 4)
                {
                    work = !work;
                }
            }
        }
    }
}
