using System;

namespace Homework4
{

    class Program
    {
        [Flags]
        enum Months
        {
            none,
            Jan,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        }
       
        static void Main(string[] args)

        {
            Console.WriteLine("Введите номер  месяца");
            string k = Console.ReadLine();
            int n = Int32.Parse(k);

          

            if (n > 12)
            {
                Console.WriteLine("Месяца с таким номером не существует");
            }

            if (n <= 12)
            {
                Months month = (Months)Enum.GetValues(typeof(Months)).GetValue(n);
                Console.WriteLine((month));
            }
            


            if (n >= 1)
            {
                if (n <= 3)
                {
                    Console.WriteLine("Четверть года: 1");
                }
                else if (n >= 4)
                {
                    if (n <= 6)
                    {
                        Console.WriteLine("Четверть года: 2");
                    }
                    else if (n >= 7)
                    {
                        if (n <= 9)
                        {
                            Console.WriteLine("Четверть года: 3");
                        }
                        else if (n >= 10)
                        {
                            if (n <= 12)
                            {
                                Console.WriteLine("Четверть года: 4");
                            }
                        }
                    }
                }
            }

            if (n >= 1 & n <= 2)
            {
                Console.WriteLine("Зима");
            }


            else

                    if (n >= 3 & n <= 5)
            {
                Console.WriteLine("Весна");
            }

            else
                    if (n >= 6 & n <= 8)
            {
                Console.WriteLine("Лето");
            }

            else
                if (n >= 9 & n <= 11)
            {
                Console.WriteLine("Осень");
            }
        
            else 
                if (n == 12)
            {
                Console.WriteLine("Зима");
            }
           Console.ReadKey();





        }

    }
}
        
   