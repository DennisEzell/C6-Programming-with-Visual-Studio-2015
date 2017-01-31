using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Enumeration.Enum;

namespace Enumeration
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
