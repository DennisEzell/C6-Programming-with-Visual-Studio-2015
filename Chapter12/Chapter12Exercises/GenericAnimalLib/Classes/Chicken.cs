using static System.Console;

namespace GenericAnimalLib.Classes
{
    public class Chicken : Animal
    {
        public void LayEgg() => WriteLine($"{name} has laid an egg");
        public Chicken(string newName) : base(newName) { }

        public override void MakeANoise() => WriteLine($"{name} says 'cluck'!");        
    }
}
