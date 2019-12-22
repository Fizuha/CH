using System;
using System.Collections.Generic;
using System.Text;
using Task1_7.FirstTasks;
using Task1_7.Task_2;
using Task1_7.Task_3;

namespace Task1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Hello msg = new Hello();
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
               FigureCheck fgr = new FigureCheck();
               fgr.FigureChecking();
               Fibonachi fbn = new Fibonachi();
               fbn.FibCount();*/
            /*   First rev = new First();
               rev.Revers();
               Second pal = new Second();
               pal.palindrome();
               Third rwo = new Third();
               rwo.revwordord();
               Forth rew = new Forth();
               rew.revEachWord();
               Fifth cC = new Fifth();
               cC.charCount();
               Six rD = new Six();
              rD.remDouple();
                  Seven ss = new Seven();
              ss.substring();*/
              //3.1 Fractional
            Fractional fr = new Fractional();
            Console.WriteLine(fr.Add(12.3,11.1));
            Console.WriteLine(fr.Sub(12.3,11.1));
            Console.WriteLine(fr.Mul(12.3,11.1));
            Console.WriteLine(fr.Check(12.3,11.1));
            //3.2_Money
            Money bal = new Money();
            bal.UAH = 534;
            bal.COIN = 345;
            CalcMoney c = new CalcMoney();
            double sum=c.Conc(bal.UAH, bal.COIN);
            Console.WriteLine(c.Add(sum, 4));
            Console.WriteLine(c.Sub(sum, 4));
            Console.WriteLine(c.Mul(sum, 4));
            Console.WriteLine(c.Div(sum, 4));
            Console.WriteLine(c.Check(sum, 4));
            //3.3 Equal trapezoid 
            int N = Convert.ToInt32(Console.ReadLine());
             Trapezoid  []T =  new Trapezoid[N];
            for(int i =0;i<N;i++)
            {
                T[i] = new Trapezoid();
            }          
        }
    }
}
