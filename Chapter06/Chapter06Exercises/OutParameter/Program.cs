using static System.Console;

namespace OutParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxIndex;
            int[] val = { 1, 9, 7, 5, 8, 10 };
            WriteLine($"Array containing: 1,9,7,5,8,10\n"
                + $"Max Value: {MaxValue(val, out maxIndex)} \nIndex of Max Value: {maxIndex}");
            ReadKey();
        }

        static int MaxValue(int [] intArray, out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;
            for(int i = 1; i < intArray.Length; i++)
            {
                if(intArray[i] > maxVal)
                {
                    maxVal = intArray[i];
                    maxIndex = i;
                }                   
            }

            return maxVal;
        }
    }
}
