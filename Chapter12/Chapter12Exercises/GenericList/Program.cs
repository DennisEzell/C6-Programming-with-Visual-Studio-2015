using AnimalLib.Class;
using System.Collections.Generic;
using static System.Console;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalCollection = new List<Animal> { new Cow("Rual"), new Chicken("Donna") };
            animalCollection.ForEach(a => a.Feed());
            ReadKey();
        }
    }
}
