using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.Task_2
{
    class Seven
    {
        public void substring()
        {
            Console.WriteLine("\nEnter string to find substrings");
            string inp = Console.ReadLine();
            int k, n;
            for (n = 0; n < inp.Length; n++)
            {
                k = 1;
                for (int i = 0; i < inp.Length-n; i++)
                {
                    
                    Console.WriteLine(inp.Substring(n,k));
                    k++;
                }
            }
            
            


           /* char[] str = inp.ToCharArray();
            string ready="";
            
            for (int i = 0; i < str.Length; i++)
            {
                if (ready.IndexOf(str[i]) == -1)
                {
                    ready += str[i];
                    Console.Write(str[i]);
                }
               

                
            }*/
        } 
    }
}
