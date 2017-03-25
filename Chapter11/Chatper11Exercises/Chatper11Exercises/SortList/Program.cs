using SortList.Class;
using SortList.Comparer;
using System;
using System.Collections;
using static System.Console;

namespace SortList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList
            {
                new Person("Rual", 30),
                new Person("Donna", 25),
                new Person("Mary", 27),
                new Person("Ben", 44)
            };

            foreach (Person person in list)
            {
                WriteLine($"{person.Name} ({person.Age})");
            }

            WriteLine();
            WriteLine("People sorted with default comparer (by age: )");
            list.Sort();

            foreach (Person person in list)
            {
                WriteLine($"{person.Name} ({person.Age})");
            }

            WriteLine();
            WriteLine("People sorted with nondefault comparer (by name: )");
            list.Sort(PersonComparerName.Default);

            foreach (Person person in list)
            {
                WriteLine($"{person.Name} ({person.Age})");
            }

            ReadKey();
        }
    }
}
