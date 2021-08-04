using System;

namespace example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа №2 пример_5
            // Архиреев Аркадий 
            /* 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
             * нужно ли человеку похудеть, набрать вес или всё в норме.
             *    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/

            Console.Write("Введите свой вес (кг): ");
            var weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой рост (м): ");
            var growth = Convert.ToDouble(Console.ReadLine());

            var bmi = weight / (growth * growth);
            Console.WriteLine($"Индекс массы тела: {bmi:F2};");

            if (bmi < 18.5000)
            {
                Console.WriteLine("Недостаточный вес");
            }
            else if(18.50000 < bmi && bmi < 24.9999)
            {
                Console.WriteLine("Нормальный вес");
            }
            else if(25.0000 < bmi && bmi < 29.9999)
            {
                Console.WriteLine("Избыточный вес");
            }
            else
            {
                Console.WriteLine("Тучность");
            }
        }
    }
}
