using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.FirstTasks
{
    class Fibonachi
    {
        public void FibCount()
        {
            int n;
            int[] fib= new int[1000];
            fib[0] = 1; fib[1] = 1;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = fib.Length; i < n; i++)
            {
               fib[i] = fib[i - 1] + fib[i - 2];
            }
            for (int i = 0; i < fib.Length; i++)
            {
                if (i != 0) Console.WriteLine(fib[i]);
                else break;
            }
        }
    }
}
