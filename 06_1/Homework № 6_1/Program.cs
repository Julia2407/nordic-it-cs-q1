using System;

namespace Homework___6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            try
            {
                Console.WriteLine("Введите сумму первоначального взноса в рублях");
                double contrb = double.Parse(Console.ReadLine());
                Console.WriteLine(" Введите ежедневный процент дохода в виде десятичной дроби (1% = 0.01)");
                double proc = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите желаемую сумму накопления в рублях");
                int summ = int.Parse(Console.ReadLine());

                int k = 0;
                double c = contrb;
                while (c < summ) 
                {
                    c = (c * proc) + c; 
                    k++;
                }
                Console.WriteLine($"Необходимое количество дней для накопления желаемой суммы: {k}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено неверное значение");
                goto start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введен неверный формат");
                goto start;

            }
              
        }
    }
}
