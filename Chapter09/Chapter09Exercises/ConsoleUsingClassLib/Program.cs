using static System.Console;
using ClassLibrary;
namespace ConsoleUsingClassLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adding reference to class library
            // Right click Project --> Add --> Reference --> 
            // Browse into the Class Library folder into \bin\Debug\ClassLibrary.dll

            MyExternalClass myObj = new MyExternalClass();
            WriteLine(myObj.ToString());
            ReadKey();
        }
    }
}
