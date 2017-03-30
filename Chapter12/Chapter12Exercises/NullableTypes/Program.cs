using NullableTypes.Class;
using static System.Console;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = GetVector("vector1");
            Vector v2 = GetVector("vector2");
            WriteLine($"{v1} + {v2} = {v1 + v2}");
            WriteLine($"{v1} - {v2} = {v1 - v2}");
            ReadKey();
        }

        static Vector GetVector(string name)
        {
            WriteLine($"Input {name} magnitude");
            double? r = GetNullableDouble();
            WriteLine($"Input {name} angle (in degrees)");
            double? theta = GetNullableDouble();

            return new Vector(r, theta);
        }

        static double? GetNullableDouble()
        {
            double? result;
            string userInput = ReadLine();
            try
            {
                result = double.Parse(userInput);
            } catch {
                result = null;
            }

            return result;
        }
    }
}
