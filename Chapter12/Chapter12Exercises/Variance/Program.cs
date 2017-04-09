using GenericAnimalLib.Classes;
using GenericAnimalLib.Comparators;
using GenericAnimalLib.Interfaces;
using static System.Console;

namespace Variance
{
    /// <summary>
    /// Adding reference to Chapter 12 GenericAnimalLib dll to
    /// avoid havign to define all the animal class again.
    /// This Library is a copy over form the Chaper 12 
    /// DefineGenericClass.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Cow myCow = new Cow("Geronimo");

            //Covariant relationship:
            //Base Class interface type (animalMethaneProducer : Animal) refering to derived class variable (cowMethaneProducer : Cow)
            IMethaneProducer<Cow> cowMethaneProducer = myCow;
            IMethaneProducer<Animal> animalMethaneProducer = cowMethaneProducer;

            //Contravariant relationship:
            //Dervied class interface type (superCowGrassMuncher : SuperCow) refering to a base class variable (cowGrassMuncher : Cow)
            IGrassMuncher<Cow> cowGrassMuncher = myCow;
            IGrassMuncher<SuperCow> superCowGrassMuncher = cowGrassMuncher;

            Farm<Cow> cowFarm = new Farm<Cow>
            {
                myCow,
                new SuperCow("Tonto"),
                new Cow("Gerald"),
                new Cow("Phil"),
                new SuperCow("Zed")
            };

            cowFarm.SortAnimals(new AnimalNameLengthComparer());
            cowFarm.WriteAnimals();

            ReadKey();
        }

    }
}
