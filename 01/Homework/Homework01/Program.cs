using System;
using System.Threading;
namespace Homework01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Здравствуйте, {name}");
            Thread.Sleep(5000);
            Console.Write($"До свидания, {name}"); ;
            Console.ReadKey();
        }
    }
}
