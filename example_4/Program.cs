using System;

namespace example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа №2 пример_4
            // Архиреев Аркадий 
            /* 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
             * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
             * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
             * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.*/
            var attempt = 0;
            string loginTrue = "root";
            string passwordTrue = "GeekBrains";

            do
            {
                Console.Write("Введи логин: ");
                string login = Console.ReadLine();
                Console.Write("Введи пароль: ");
                string password = Console.ReadLine();

                if (login == loginTrue && password == passwordTrue)
                {
                    Console.WriteLine("истина");
                    break;
                }
                else
                {
                    Console.WriteLine("ложь");
                    attempt++;
                    Console.WriteLine($"Попытка: {attempt} из 3");
                }
            } while (attempt < 3);
        }
    }
}
