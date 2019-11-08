using System;

namespace Сложный_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tbl = new int[10];
           

            tbl[0] =1;
            tbl[1] = 2;
            tbl[2] = 3;
            tbl[3] = 4;
            tbl[4] = 5;
            tbl[5] = 6;
            tbl[6] = 7;
            tbl[7] = 8;
            tbl[8] = 9;
            tbl[9] = 10;


            for (int j = 0; j < 10; j++)
            {
                
                Console.WriteLine(tbl[0] * tbl[j] + " " + tbl[1] * tbl[j] + " " + tbl[2] * tbl[j] + " " + tbl[3] * tbl[j] + " " + tbl[4] * tbl[j] + " " + tbl[5] * tbl[j] + " " + tbl[6] * tbl[j] + " " + tbl[7] * tbl[j] + " " + tbl[8] * tbl[j] + " " + tbl[9] * tbl[j]);
                    
            }

            Console.ReadKey();
        }
    }
}
