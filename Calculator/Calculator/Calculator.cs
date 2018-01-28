using System;
namespace Calculator
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
