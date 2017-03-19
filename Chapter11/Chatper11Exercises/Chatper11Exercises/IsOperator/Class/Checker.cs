
using static System.Console;

namespace IsOperator.Class
{
    public interface IMyInterface { }
    public class ClassA : IMyInterface { }
    public class ClassB : IMyInterface { }
    public class ClassC { }
    public class ClassD : ClassA { }
    public struct MyStruct : IMyInterface { }
    public class Checker
    {
        public void Check(object obj)
        {
            string isClassA;
            string isMyInterface;
            string isMyStruct;
 
            isClassA = (obj is ClassA)
                ? "Variable can be converted to ClassA"
                : "Variable cannot be converted to ClassA";

            isMyInterface = (obj is IMyInterface)
                ? "Variable can be converted to IMyInterface"
                : "Variable cannot be converted to IMyInterface";

            isMyStruct = (obj is MyStruct)
                ? "Variable can be converted to MyStruct"
                : "Variable cannot be converted to MyStruct";

            WriteLine($"{isClassA}");
            WriteLine($"{isMyInterface}");
            WriteLine($"{isMyStruct}");
        }
    }
}
