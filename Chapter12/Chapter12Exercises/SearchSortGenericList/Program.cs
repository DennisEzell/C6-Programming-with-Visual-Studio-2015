using SearchSortGenericList.Class;
using System;
using static System.Console;

namespace SearchSortGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            Vectors route = new Vectors();

            route.Add(new Vector(2.0, 90.0));
            route.Add(new Vector(1.0, 180.0));
            route.Add(new Vector(0.5, 45.0));
            route.Add(new Vector(2.5, 315.0));
            WriteLine(route.Sum());
            //The following two lines are commented out since they can be reduced to a method group
            //Comparison<Vector> sorter = new Comparison<Vector>(VectorDelegate.Compare);
            //route.Sort(sorter);
            route.Sort(VectorDelegate.Compare);
            WriteLine(route.Sum());
            Predicate<Vector> searcher = new Predicate<Vector>(VectorDelegate.TopRightQuadrant);
            Vectors topRightQuadrantRoute = new Vectors(route.FindAll(searcher));
            WriteLine(topRightQuadrantRoute.Sum());
            ReadKey();
        }
    }
}
