using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Ch05Ex02_Enum.Enum;

namespace Ch05Ex02_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Orientation myDirection = Orientation.north;
            WriteLine($"myDirection =  {myDirection}");
            ReadKey();
        }
    }
}
