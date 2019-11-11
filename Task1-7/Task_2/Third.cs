using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.Task_2
{
    class Third
    {
        public void revwordord()
        {
            
            string inp=Console.ReadLine();
            string[] wrd=inp.Split(' ');
            for(int i = wrd.Length - 1; i >=0 ; i--)
            {
                Console.Write(wrd[i]+" ");
            }
            

        } 
    }
}
