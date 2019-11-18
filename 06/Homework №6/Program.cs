using System;

namespace Homework__6
{
    class Program
    {
        static void Main(string[] args)
        {
            start1:
            try
            {
                start:
                Console.WriteLine("Введите положительное натуральное число не более двух миллиардов");
                int n = int.Parse(Console.ReadLine());
                if (n < 0 | n < 10)
                {
                    Console.WriteLine("Введено неверное значение!");
                    goto start;
                }
                int k = 0;
                int b;
                int a = n;
                while (a > 0) 
                {
                    b = a % 10;
                    a /= 10;
                    if (b % 2 == 0)
                    {
                        k++;
                    }

                }
                Console.WriteLine($"В числе {n} содержится следующее количество четных цифр: {k}.");
                Console.WriteLine("Нажмите любую клавишу для выхода");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка System.OverflowException!Попробуйте еще раз");
                goto start1;
            }  
            catch (FormatException)
            {
                Console.WriteLine(" Ошибка System.FormatException! Попробуйте ещё раз");
                goto start1;
            }
          
        }
    }
}
