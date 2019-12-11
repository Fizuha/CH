using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.Task_3
{
    class Fractional
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }public double Mul(double x, double y)
        {
            return x*y;
        }public bool Check(double x, double y)
        {
            return (x==y)?true:false;
        }
    }
}
