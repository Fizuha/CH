using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.Task_3
{
    public class Trapezoid
    {   
       public double X1 { get; set; }
       public double X2 { get; set; }
       public double X3 { get; set; }
       public double X4 { get; set; }
       public double Y1 { get; set; }
       public double Y2 { get; set; }
       public double Y3 { get; set; }
       public double Y4 { get; set; }
    }
    public class Constr
    {
        public double Lenth(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt( Math.Pow((X1 - X2),2)+ Math.Pow((Y1 - Y2),2));
        }
        public bool IfEqual (double a, double b,double d1, double d2)
        {
            return (a == b) && (d1 == d2);
        }
        public void Info(double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4)
        {

            double a = Lenth(X1, Y1, X2, Y2), b = Lenth(X2, Y2, X3, Y3), c = Lenth(X3, Y3, X4, Y4), d = Lenth(X4, Y4, X1, Y1), d1 = Lenth(X1, Y1, X3, Y3), d2 = Lenth(X2, Y2, X4, Y4), S;
            Console.WriteLine("Sides of the trapezoid:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("\t");
            Console.WriteLine("Perimetr:");
            Console.WriteLine(a+b+c+d);
            Console.WriteLine("\t");
            S = Math.Sqrt(a*a - Math.Pow( (d - b)/2.0, 2));
            if (IfEqual(a, c, d1, d2)) Console.WriteLine(S); else Console.WriteLine("Can't count.");

        }
            
   

    }
}
