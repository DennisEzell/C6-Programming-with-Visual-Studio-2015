using IsOperator.Class;
using static System.Console;

namespace IsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Checker check = new Checker();
            ClassA classA = new ClassA();
            ClassB classB = new ClassB();
            ClassC classC = new ClassC();
            ClassD classD = new ClassD();

            MyStruct myStruct = new MyStruct();
            object obj = myStruct;
            WriteLine("Analyzing ClassA type variable");
            check.Check(classA);
            WriteLine("\nAnalyzing ClassB type variable");
            check.Check(classB);
            WriteLine("\nAnalyzing ClassC type variable");
            check.Check(classC);
            WriteLine("\nAnalyzing ClassD type variable");
            check.Check(classD);
            WriteLine("\nAnalzying MyStruct type variable");
            check.Check(myStruct);
            WriteLine("\nAnalyzing boxed myStruct type variable");
            check.Check(obj);
            ReadKey();
        }
    }
}
