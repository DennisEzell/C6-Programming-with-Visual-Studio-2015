using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            string userName;

            Console.WriteLine("Enter Your Name:");
            userName = Console.ReadLine();

            Console.WriteLine("Give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Let me get that second number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " + $"{ firstNumber + secondNumber}");
            Console.WriteLine($"The difference of {firstNumber} and {secondNumber} is " + $"{ firstNumber - secondNumber}");
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} is " + $"{ firstNumber * secondNumber}");
            Console.WriteLine($"The quotient  of {firstNumber} and {secondNumber} is " + $"{ firstNumber / secondNumber}");
            Console.WriteLine($"The remainder of {firstNumber} and {secondNumber} is " + $"{ firstNumber % secondNumber}");
            Console.ReadKey();
        }
    }
}
