using static System.Console;
using NestedClasses.Class;

namespace NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Outer outerClass = new Outer();
            WriteLine($"outerClass.State = {outerClass.State}");
            Outer.Nested nestedClass = new Outer.Nested();
            nestedClass.SetPrivateState(outerClass, 999);
            WriteLine($"outerClass.State = {outerClass.State}");
            ReadKey();
        }
    }
}
