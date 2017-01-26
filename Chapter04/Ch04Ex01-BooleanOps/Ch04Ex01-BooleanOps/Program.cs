using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Static using 
using static System.Console;
using static System.Convert;
namespace Ch04Ex01_BooleanOps
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter an integer:");
            int val = ToInt32(ReadLine());

            bool isLessThanTen = val < 10;
            bool isBetweenZeroAndFive = (0 <= val) && (val <= 5);

            WriteLine($"Integer is less than 10? {isLessThanTen}");
            WriteLine($"Integer is between Zero and Five? {isBetweenZeroAndFive}");

            WriteLine($"Exactly one of the above statements are true?  {isLessThanTen ^ isBetweenZeroAndFive}");

            ReadKey();
        }
    }
}
