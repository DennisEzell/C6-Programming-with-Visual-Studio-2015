using static System.Console;

namespace ParameterArray
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Summed Values = {SumVals(1, 2, 5, 8, 9)}");
            ReadKey();
        }

        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach(int val in vals)
            {
                sum += val;
            }

            return sum;
        }
    }
}
