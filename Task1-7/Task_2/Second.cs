using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.Task_2
{
    class Second
    {
        public void palindrome()
        {
            Console.WriteLine("\nEnter string to check if it is palindrome");
            bool outp = true;
            string inp=Console.ReadLine();
            inp.ToCharArray();
            for(int i = 0; i <= inp.Length/2-1; i++)
            {
                if (inp[i] != inp[inp.Length - i-1])
                {
                    outp = false;
                    break;
                }
                    
            }
            Console.WriteLine(outp);

        } 
    }
}
