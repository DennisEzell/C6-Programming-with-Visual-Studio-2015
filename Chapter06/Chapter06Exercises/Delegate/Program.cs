using static System.Console;
using static System.Convert;

namespace Delegate
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);
        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;

        static void Main(string[] args)
        {
            ProcessDelegate process;
            WriteLine("Enter 2 numbers seperated by a comma");
            var input = ReadLine().Split(',');
            double param1 = ToDouble(input[0]);
            double param2 = ToDouble(input[1]);

            WriteLine("Enter M to multiply or D to divide:");

            process = (ReadLine() == "M")
                ? new ProcessDelegate(Multiply)
                : new ProcessDelegate(Divide);

            WriteLine($"Result: {process(param1,param2)}");
            ReadKey();
        }
    }
}
