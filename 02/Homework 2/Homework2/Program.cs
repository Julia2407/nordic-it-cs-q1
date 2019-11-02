using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string a = Console.ReadLine();
            double x = double.Parse(a);
            Console.WriteLine("Введите второе число");
            string b = Console.ReadLine();
            double y = double.Parse(b);
            double res = x + y;
            double res2 = Math.Abs(x - y);
            double res3 = x * y;
            Console.WriteLine($"Сумма = {res}");
            Console.WriteLine($"Разность = {res2}");
            Console.WriteLine($"Произведение = {res3}");
            Console.ReadKey();
        }
    }
}
