using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.Task_3
{
    public class Money
    {
        public int UAH{ get; set; }
        public uint COIN { get; set; }
    }
    public class CalcMoney
    {
        public double Conc(int x, uint y)
        {
            return (x + y / Math.Pow(10.00, Convert.ToString(y).Length));
        }
        public double Add(double x, double y)
        {
            return (x + y);
        }
        public double Sub(double x, double y)
        {
            return (x - y);
        }
        public double Mul(double x, double y)
        {
            return (x * y);
        }
        public double Div(double x, double y)
        {
            return (x / y);
        }
        public bool Check(double x, double y)
        {
            return ((x == y) ? true : false);
        }
    }
}
