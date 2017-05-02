using static System.Console;
using Microsoft.CSharp.RuntimeBinder;
using DynamicTypes.Classes;

namespace DynamicTypes
{
    class Program
    {
        static int callCount = 0;
        static dynamic GetValue()
        {

            return callCount++ == 0 
                ? (IClass)new AddClass()
                : (IClass)new EmptyClass();
        }
        static void Main(string[] args)
        {
            try
            {
                dynamic firstResult = GetValue();
                dynamic secondResult = GetValue();

                WriteLine($"firstResult is: {firstResult.ToString()}");
                WriteLine($"secondResult is: {secondResult.ToString()}");
                WriteLine($"firstResult call: {firstResult.Add(2,3)}");
                WriteLine($"secondResult call: {secondResult.Add(2,3)}");
            }
            catch (RuntimeBinderException ex)
            {
                WriteLine(ex.Message);
            }
            ReadKey();
        }
    }
}
