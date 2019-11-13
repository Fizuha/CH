using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.Task_2
{
    class Fifth
    {
        public void charCount()
        {
            Console.WriteLine("\nEnter string to count characters");
            string inp = Console.ReadLine();
            char[] str = inp.ToCharArray();
            string ready="";
            
            for (int i = 0; i < str.Length; i++)
            {
                if (ready.IndexOf(str[i]) == -1) 
                { Console.WriteLine("'"+str[i] + "' -" + count(str[i], str));
                    ready += str[i];                
                }
                
                
            }
            
        } 
        public int count(char x,char[] str)
        {
            int k=0;
            for(int i=0; i < str.Length; i++)
            {
                if (x == str[i]) k++;
            }
            return (k);
        }
    }
}
