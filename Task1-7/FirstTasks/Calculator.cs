using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.FirstTasks
{
    class Calculator
    {
        public void Calculations()
        {
            int n, a, b = 0;
            for (; ; )
            {
                Console.WriteLine("Что ты хочеш?\n 1-Сложить\n 2-Умножить\n 3-Поделить\n 4-Вычесть\n 5-Найти модуль\n 0-Выход из програмы");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 0) break;
                Console.WriteLine("Введите число(числа)");
                a = Convert.ToInt32(Console.ReadLine());
                if (n < 5) b = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case (1):
                        Console.WriteLine(a + b);
                        break;

                    case (2):
                        Console.WriteLine(a * b);
                        break;

                    case (3):
                        if (b == 0) { Console.WriteLine("На ноль сам в столбик дели"); break; }
                        Console.WriteLine((double)a / b);
                        break;

                    case (4):
                        Console.WriteLine(a - b);
                        break;

                    case (5):
                        Console.WriteLine(Math.Abs(a));
                        break;
                    default:
                        Console.WriteLine("А ты цыфирки не перепутал?");
                        break;
                }
            }

        }
    }
}
