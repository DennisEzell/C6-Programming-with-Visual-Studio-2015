using System;
using static System.Console;
namespace FieldsMethodsProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Creating object myObj...");
            MyClass myObj = new MyClass("My Object");
            WriteLine("myObj created");

            for(int i = -1; i <= 0; i++)
            {
                try
                {
                    WriteLine($"\nAttempting to assign {i} to myObj.Val...");
                    myObj.Val = i;
                    WriteLine($"Value {myObj.Val} assigned to myObj.val...");
                }
                catch (Exception e)
                {
                    WriteLine($"Exception {e.GetType().FullName} thrown.");
                    WriteLine($"Message:\n\"{e.Message}\"");
                }
            }

            WriteLine($"\nOutputting myObj.toString()...\n{myObj.ToString()}\nmyObj.toString() Output.");
            WriteLine($"\nMyDoubleIntProp = 5...\nGetting MyDoubleIntProp of 5 is {myObj.MyDoubledIntProp}");
            ReadKey();
        }
    }
}
