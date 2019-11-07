using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имена");
           

            string[] names = new string[3];
            names[0] = Console.ReadLine();
            names[1] = Console.ReadLine();
            names[2] = Console.ReadLine();

            Console.WriteLine("Введите возраст");

            string[] age = new string[3];
            age[0] = Console.ReadLine();
            age[1] = Console.ReadLine();
            age[2] = Console.ReadLine();

             for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine("Name: " + names[i] +"," + " " + "age in 4 years:" +" " + age [i]);
                }
            Console.ReadKey();
        }
    }
}
