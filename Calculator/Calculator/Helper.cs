using System;
namespace Calculator
{
    public class Helper : IHelper
    {
        public int ConvertStringToInt(string x)
        {
            return Int32.Parse(x);
        }
    }
}
