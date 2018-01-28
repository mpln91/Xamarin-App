using System;
namespace Calculator
{
    public class Calculator : ICalculator
    {
        private readonly IHelper m_helper = new Helper();
        public int Add(string x, string y)
        {
            return (m_helper.ConvertStringToInt(x) + m_helper.ConvertStringToInt(y));
        }

        public int Multiply(string x, string y)
        {
            return (m_helper.ConvertStringToInt(x) * m_helper.ConvertStringToInt(y));
        }
    }
}
