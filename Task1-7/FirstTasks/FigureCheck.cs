using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.FirstTasks
{
    class FigureCheck
    { public void FigureChecking()
        {
            Console.WriteLine("Что вы хотите:\n 1-Проверить треугольник\n 2-Определить фигуру");
            int x1,x2,x3,y1,y2,y3, n = Convert.ToInt32(Console.ReadLine());
            double a, b, c;
            switch (n)
            {
                case 1:
                    Console.WriteLine("x1=");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("y1=");
                    y1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("x2=");
                    x2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("y2=");
                    y2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("x3=");
                    x3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("y3=");
                    y3 = Convert.ToInt32(Console.ReadLine());
                    a = dist(x1, y1, x2, y2);
                    b = dist(x2, y2, x3, y3);
                    c = dist(x3, y3, x1, y1);
                    Console.WriteLine(IsTriangle(a, b, c));
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Перевірте правильність вводу");
                    break;
            }

        }
        public double dist(int x1,int y1,int x2,int y2)
        {
            double d;
            d=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
            return (d);
        }
        public bool IsTriangle(double a, double b, double c) {
            bool k=false;
            if (((a + b) > c)|| ((b + c) > a) || ((a + c) > b))k = true;
            return (k);
        }
    }
}
