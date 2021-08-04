using System;

namespace training_manual
{
    class Program
    {
        // Перечисления
        // Вводится число, программа печатает, какой это день недели: 
        enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri }
        static void Main(string[] args)
        {
            // УСЛОВИЯ
            // Задача.Ввести два числа и вывести наибольшее из них.
            /*Console.Write("Введи число a: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Введи число b: ");
            var b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"наибольшее число a: {a}");
            }
            else
            {
                Console.WriteLine($"наибольшее число b: {b}");
            }

            int max = a;
            // Неполная форма условного оператора
            if (b > max)
                max = b;
            Console.WriteLine($"максимальное число {max}");*/


            // Тернарная операция
            // Вывод на экран текста — чётное или нечётное число
            /*Console.Write("Введи число: ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a}:" + ((a % 2 == 0) ? " четное число" : " не четное число"));*/


            // Оператор выбора
            // Вводится число, программа печатает, какой это сезон:
            /*Console.Write("Введи число от 1 до 12: ");
            var a = int.Parse(Console.ReadLine());
            string s;
            switch (a)
            {
                case 1: 
                case 2: 
                case 12: s = "Зима";
                    break;
                case 3:
                case 4:
                case 5: s = "Весна";
                    break;
                case 6:
                case 7:
                case 8: s = "Лето";
                    break;
                case 9:
                case 10:
                case 11:  s = "Осень";
                    break;
                default:
                    s = "ничего";
                    break;
            }
            Console.WriteLine($"Сезон {s}");*/


            // Перечисления
            // Вводится число, программа печатает, какой это день недели:
            Console.Write("Введи число от 1 до 7: ");
            var a = int.Parse(Console.ReadLine());

            
        }
    }
}
