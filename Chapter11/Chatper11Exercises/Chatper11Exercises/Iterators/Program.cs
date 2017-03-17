using System.Collections;
using static System.Console;
namespace Iterators
{
    public class Program
    {
        public static IEnumerable SimpleList()
        {
            yield return "line 1";
            yield return "line 2";
            yield return "line 3";
        }
        static void Main(string[] args)
        {
            //Notice we are asking for "string" objects even though we are returning IEnumerable references.
            //The compiler is smart enough that you can interpret the returned values as whatever type
            //you want in the context of the foreach loop
            foreach(string line in SimpleList())
            {
                WriteLine(line);
            }
            ReadKey();
        }
    }
}
