using static System.Console;
using ClassVsStruct.Class;
using ClassVsStruct.Struct;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            MyClass objectB = objectA; //same object as objectA
            objectA.val = 10;
            objectB.val = 20;

            MyStruct structA = new MyStruct();
            MyStruct structB = structA; //Different location in memory from structA
            structA.val = 30;
            structB.val = 40;

            WriteLine($"objectA.val = {objectA.val}");
            WriteLine($"objectB.val = {objectB.val}");
            WriteLine($"structA.val = {structA.val}");
            WriteLine($"structB.val = {structB.val}");
            ReadKey();
        }
    }
}
