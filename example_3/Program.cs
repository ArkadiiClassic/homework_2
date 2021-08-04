using System;

namespace example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа №2 пример_3
            // Архиреев Аркадий 
            /* 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.*/

            int a, sum = 0;
            Console.WriteLine("подсчет нечетных положительных чисел, введите 0, чтобы закончить ввод чисел: ");
            do
            {
                a = int.Parse(Console.ReadLine());
                if ((a % 2 != 0) && a >= 0)
                {
                    sum = a + sum;
                }
                
            } while (a != 0);
            Console.WriteLine($"сумма всех нечетных положительных чисел: {sum}");
        }
    }
}
