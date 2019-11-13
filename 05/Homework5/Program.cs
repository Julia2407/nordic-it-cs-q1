using System;

namespace Homework5
  
{
    class Program
    {
        [Flags]
        enum figures
        { 
            none,
            circle,
            triangle,
            rectangle

        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите тип фигуры (1 круг, 2 равносторонний треугольник, 3 прямоугольник)");
            int n = int.Parse(Console.ReadLine());
            if (n>3)
            {
                throw new Exception("Номер не соответствует ни одной из фигур");
            }
            string message;
            switch (n)
            {
                case 1:
                    message = "Введите диаметр";
                start:
                    try
                    {
                        Console.WriteLine(message);
                        double d = double.Parse(Console.ReadLine());
                        double S = Math.PI * Math.Pow(d / 2, 2);
                        double P = 2 * Math.PI * (d / 2);
                        Console.WriteLine($"Площадь = {S}");
                        Console.WriteLine($"Периметр = {P}");
                     }
                    catch
                    {
                        Console.WriteLine("Ошибка! Введено нечисловое значение!");
                        goto start;
                    }
                    break;
                case 2:
                    message = "Введите длину стороны";
                start1:
                    try
                    {
                        Console.WriteLine(message);
                        double a = double.Parse(Console.ReadLine());
                        double S1 = (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
                        double P1 = a * 3;
                        Console.WriteLine($"Площадь = {S1}");
                        Console.WriteLine($"Периметр = {P1}");
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Введено нечисловое значение!");
                        goto start1;
                    }
                    break;
                case 3:
                    message = "Введите ширину и высоту";
                start2:
                    try
                    {
                        Console.WriteLine(message);
                        double b = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        double S2 = b * h;
                        double P2 = (b + h) * 2;
                        Console.WriteLine($"Площадь = {S2}");
                        Console.WriteLine($"Периметр = {P2}");
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Введено нечисловое значение!");
                        goto start2;
                    }
                    break;
            } 

            Console.ReadKey();



        }
    }
}
