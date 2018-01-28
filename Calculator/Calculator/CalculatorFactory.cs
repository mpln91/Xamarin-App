using System;
namespace Calculator
{
    public class CalculatorFactory
    {
        public CalculatorFactory()
        {
        }

        public void Calculate(string x, string y, string type)
        {
            switch (type)
            {
                case "Add":
                    return new Add();
                case "Multiply":
                    return new Multiply();
                default:
                    throw NotImplementedException();
            }

        }
    }
}
