using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.Task_2
{
    class First
    {
        public void Revers()
        {
            string inp=Console.ReadLine();
            string outp= "";
            for(int i = inp.Length-1; i >= 0; i--)
            {
                outp += inp[i];
            }
            Console.WriteLine(outp);

        } 
    }
}
