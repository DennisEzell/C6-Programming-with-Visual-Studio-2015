using DefineGenericClass.Class;
using System.Linq;
using static System.Console;

namespace DefineGenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm<Animal> farm = new Farm<Animal>
            {
                new Cow("Rual"),
                new Chicken("Donna"),
                new Chicken("Mary"),
                new SuperCow("Ben")
            };

            farm.MakeNoises();
            WriteLine("\nCreating Dairy Farm\n");
            Farm<Cow> diaryFarm = farm.GetCows();
            diaryFarm.MakeNoises();
            WriteLine("\nFeeding Diary Farm\n");
            diaryFarm.FeedTheAnimals();
            WriteLine("\nFinding all SuperCows\n");

            diaryFarm.Animals
                .FindAll(a => a is SuperCow)
                .ForEach(a => (a as SuperCow).Fly());

            WriteLine("\nCreating Chicken Coup");
            Farm<Chicken> chickenCoup = farm.GetSpecies<Chicken>();
            WriteLine("Feeding Chicken Coup");
            chickenCoup.FeedTheAnimals();

            WriteLine("\nCreating Super Diary Farm");
            Farm<SuperCow> superDiaryFarm = farm.GetSpecies<SuperCow>();
            WriteLine("Feeding Super Cows");
            superDiaryFarm.FeedTheAnimals();


            ReadKey();
        }
    }
}
