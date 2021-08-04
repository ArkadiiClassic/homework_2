using System;

namespace example_1
{
    class Program
    {
        static int MethodMin(int a, int b, int c)
        {
            if ((a < b)&&(a < c))
            {
                return a;
            }
            else if (b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
            
        }
        static void Main(string[] args)
        {
            // Домашняя работа №2 пример_1
            // Архиреев Аркадий 
            /* 1. Написать метод, возвращающий минимальное из трёх чисел.*/

            Console.Write("введи число a: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("введи число b: ");
            var b = int.Parse(Console.ReadLine());
            Console.Write("введи число c: ");
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine("Минимальное число из трех введеных: " + MethodMin(a, b, c));
        }
    }
}
