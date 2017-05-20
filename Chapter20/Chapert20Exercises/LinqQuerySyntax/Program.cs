using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuerySyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names =
            {
                "Dennis",
                "Daniel",
                "Christy",
                "Paul",
                "Lauren",
                "Jeremy",
                "Josh",
                "Velma",
                "Bobby",
                "Ray",
                "Steve",
                "Sara"
            };

            var queryResult =
                from n in names
                where n.StartsWith("S")
                select n;
        
            foreach (var name in queryResult)
            {
                WriteLine(name);
            }

            ReadKey();
        }
    }
}
