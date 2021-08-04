using System;

namespace example_2
{
    class Program
    {

        static int CalculationMethod(int a)
        {
            var s = 0;
            for (int i = 0; a > 0; i++)
            {
                a /= 10;
                s++;
            }
            return s;
        }
        static void Main(string[] args)
        {
            // Домашняя работа №2 пример_2
            // Архиреев Аркадий 
            /* 2. Написать метод подсчета количества цифр числа.*/

            Console.Write("введите число: ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine($"количество цифр: {CalculationMethod(a)}");
        }
    }
}
