using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex01_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortResult;
            long longResult;
            double doubleResult;
            string stringResult;

            short shortVal = 4;
            int integerVal = 67;
            float floatVal = 10.5F;
            double doubleVal = 99.999;
            string stringVal = "17";

            bool boolVal = true;

            WriteLine("Variable Conversion Examples\n");
            doubleResult = floatVal * shortVal;
            WriteLine($"Implicit Conversion, -> double: {floatVal} * {shortVal} -> {doubleResult}");
            shortResult = (short)floatVal;
            WriteLine($"Explicit conversion(cast), -> short: {floatVal} -> {shortResult}");
            stringResult = Convert.ToString(boolVal) + Convert.ToString(doubleVal); //Have to prefix Convert namespace, otherwise it thinking string.ToString()
            //So you can mix String interpolation with the verbatim command.
            WriteLine($@"Explicit, -> string: ""{boolVal}"" + ""{doubleVal}"" -> {stringResult}");
            longResult = integerVal + ToInt64(stringVal);
            WriteLine($"Mixed, -> long: {integerVal} + {stringVal} -> {longResult}");

            ReadKey();
        }
    }
}
