using static System.Console;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var curries = new[]
            {
                new { MainIngredient = "Lamb", Style = "Dhansak", Spiciness = 5 },
                new { MainIngredient = "Lamb", Style = "Dhansak", Spiciness = 5 },
                new { MainIngredient = "Chicken", Style = "Dhansak", Spiciness = 5 }
            };

            WriteLine(curries[0].ToString());
            /*
             *  .GetHashCode() should return a unique integer for an object based on the object's state.
             *  --The first two objects have the same property values and, by extenstion the same state, 
             *  --return the same hashcode value
             */  
            WriteLine(curries[0].GetHashCode());
            WriteLine(curries[1].GetHashCode());
            WriteLine(curries[2].GetHashCode());

            /*
             * Equals() in anonymous types compares the state of objects
             */
            WriteLine(curries[0].Equals(curries[1]));
            WriteLine(curries[0].Equals(curries[2]));

            /*
             * The == operators compares reference
             */ 
            WriteLine(curries[0] == curries[1]);
            WriteLine(curries[0] == curries[2]);
            ReadKey();
        }
    }
}
