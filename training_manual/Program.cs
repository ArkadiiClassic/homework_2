using System;

namespace training_manual
{
    class Program
    {
        // Перечисления
        // Вводится число, программа печатает, какой это день недели: 
        /*enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri }*/
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
            /*Console.Write("Введи число от 1 до 7: ");
            var a = int.Parse(Console.ReadLine());
            string s;
            switch (a)
            {
                case 1:
                    s = $"{Days.Sat}";
                    break;
                case 2:
                    s = $"{Days.Sun}";
                    break;
                case 3:
                    s = $"{Days.Mon}";
                    break;
                case 4:
                    s = $"{Days.Tue}";
                    break;
                case 5:
                    s = $"{Days.Wed}";
                    break;
                case 6:
                    s = $"{Days.Thu}";
                    break;
                case 7:
                    s = $"{Days.Fri}";
                    break;
                default:
                    s = "пустота";
                    break;
            }
            Console.WriteLine(s);*/


            // Цикл while
            // Задача. Ввести целое положительное число (<2000000000) и определить количество цифр в нём.
            /*Console.WriteLine("Ввести целое положительное число (<2000000000): ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n != 0)
            {
                count++;
                n /= 10;
            }
            Console.WriteLine(count);*/


            // Цикл do while
            // Задача. Организовать ввод данных, ограничив значения числами от 1 до 99.
            /*int n, count = 0;
            do
            {
                Console.WriteLine("от 1 до 99: ");
                n = int.Parse(Console.ReadLine());
                count++;
            } while (n < 1 || n > 99);
            Console.WriteLine("попыток: " + count);*/


            // Оператор цикла for
            // Задача. Вывести на экран 5 раз слово «Привет».
            /*for (int i = 1; i < 6; i++)
            {
                Console.Write(i + " ");
                Console.WriteLine("Привет");
            }*/
        }
    }
}
