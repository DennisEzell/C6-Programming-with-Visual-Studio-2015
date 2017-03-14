using static System.Console;
using System.Collections;
using AnimalLib.Class;

namespace ArrayVsCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Create an array type collection of Animal objects and use it:");

            Animal[] myAnimals = new Animal[2];
            Cow myCow1 = new Cow("Lea");
            myAnimals[0] = myCow1;
            myAnimals[1] = new Chicken("Noa");

            foreach (Animal animal in myAnimals)
            {
                WriteLine($"New {animal.ToString()} object added to Array collection, Name = {animal.Name}");
            }

            WriteLine($"Array collection contains {myAnimals.Length} objects");
            myAnimals[0].Feed();
            (myAnimals[1] as Chicken).LayEgg();
            WriteLine();

            WriteLine($"Create an ArrayList type collection of Animal objects and use it:");

            ArrayList myAnimalsArrayList = new ArrayList();
            Cow betsy = new Cow("Betsy");
            myAnimalsArrayList.Add(betsy);
            myAnimalsArrayList.Add(new Chicken("Andrea"));

            foreach (Animal animal in myAnimalsArrayList)
            {
                WriteLine($"New {animal.ToString()} object added to myAnimalArrayList collection, Name = {animal.Name}");
            }

            WriteLine($"ArrayList collection contains {myAnimalsArrayList.Count} objects");

            (myAnimalsArrayList[0] as Animal).Feed();
            (myAnimalsArrayList[1] as Chicken).LayEgg();
            WriteLine();

            WriteLine($"Additional manipulation of ArrayList:");

            myAnimalsArrayList.RemoveAt(0);
            (myAnimalsArrayList[0] as Animal).Feed();

            //Adds Animal objects from simple array to the ArrayList collection
            myAnimalsArrayList.AddRange(myAnimals);

            (myAnimalsArrayList[2] as Chicken).LayEgg();
            WriteLine($"The animal called {myCow1.Name} is at index {myAnimalsArrayList.IndexOf(myCow1)}");
            myCow1.Name = "Mary";
            WriteLine($"The animal is now called {(myAnimalsArrayList[1] as Animal).Name}");
            ReadKey();
        }
    }
}
