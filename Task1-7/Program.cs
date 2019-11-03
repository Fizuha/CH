using System;
using System.Collections.Generic;
using System.Text;
using Task1_7.FirstTasks;

namespace Task1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello msg = new Hello();
            msg.Message();
            ComputerText txt = new ComputerText();
            txt.Text();
            ConsoleSquere squr = new ConsoleSquere();
            squr.Squere();
            ArraySort ar = new ArraySort(); // object init
            ar.Sort();                 // object call
            Functions fun = new Functions();
            fun.Operations();
            Calculator calc = new Calculator();
            calc.Calculations();
            Crypton cry = new Crypton();
            cry.Ceasar();       


        }
    }
}
