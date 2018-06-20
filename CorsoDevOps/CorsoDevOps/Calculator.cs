using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CorsoDevOps
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
             throw new ArgumentException("Divisone per zero");
            return a / b;
        }
    }
}