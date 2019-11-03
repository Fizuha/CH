using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.FirstTasks
{
    class ConsoleSquere
    {
        
            
        public void Squere()
        {
            int i = 1;
            Console.WriteLine("Введите размер стороны куба.");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x <= size + 1; x++)
            {
                if ((x == 0) || (x == size + 1))
                {
                    for (i = 1; i <= size; i++)
                    {
                        Console.Write("_  ");
                    }
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("! ");
                    for (i = 1; i < size; i++)
                    {
                        Console.Write("   ");
                    }
                    Console.WriteLine(" !");
                }
            }
        }
    }
}
