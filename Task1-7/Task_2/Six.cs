using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.Task_2
{
    class Six
    {
        public void remDouple()
        {
            Console.WriteLine("\nEnter string to remove duplicate characters");
            string inp = Console.ReadLine();
            char[] str = inp.ToCharArray();
            string ready="";
            
            for (int i = 0; i < str.Length; i++)
            {
                if (ready.IndexOf(str[i]) == -1)
                {
                    ready += str[i];
                    Console.Write(str[i]);
                }
               

                
            }
        } 
    }
}
