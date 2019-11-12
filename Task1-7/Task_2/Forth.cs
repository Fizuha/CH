using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.Task_2
{
    class Forth
    {
        public void revEachWord()
        {
            string inp = Console.ReadLine();
            string word = "";
            char[] str=inp.ToCharArray();
            Array.Reverse(str);
            
            for (int i = str.Length-1; i >= 0; i--)
            {
                word = str[i] + word;
                if(str[i]==' ')
                {
                    Console.Write(word);
                    word = "";
                }
                
            }
            Console.Write(" "+word);
        } 
    }
}
