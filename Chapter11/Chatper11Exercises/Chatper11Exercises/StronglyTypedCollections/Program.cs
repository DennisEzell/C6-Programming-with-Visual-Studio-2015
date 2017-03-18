using static System.Console;
using AnimalLib.Collection;
using AnimalLib.Class;
/// <summary>
/// Going to make the Animal classes a Library so I can just reference it in any projects I need
/// </summary>
namespace StronglyTypedCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalsList animalCollection = new AnimalsList();
            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Kevin"));

            foreach (Animal animal in animalCollection )
            {
                animal.Feed();
            }

            ReadKey();
        }
    }
}
