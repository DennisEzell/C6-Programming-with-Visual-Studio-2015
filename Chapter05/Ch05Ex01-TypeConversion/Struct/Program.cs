using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using Enumeration.Enum;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Route myRoute;
            int myDirection = -1;
            double myDistance;

            WriteLine("1) North\n2) South\n3) East\n4) West");

            do
            {
                WriteLine("Select a direction");
                myDirection = ToInt32(ReadLine());
            }
            while ((myDirection < 1) || (myDirection > 4));

            WriteLine("Input a distance");
            myDistance = ToDouble(ReadLine());

            myRoute.direction = (Orientation)myDirection;
            myRoute.distance = myDistance;

            WriteLine($"myRoute specifies a direction of {myRoute.direction} and a distance of {myRoute.distance}");
            ReadKey();

        }
    }
}
