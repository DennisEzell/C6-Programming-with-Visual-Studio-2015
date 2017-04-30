using static System.Console;
using GenericAnimalLib.Interfaces;

namespace GenericAnimalLib.Classes
{
    public class Cow : Animal, IMethaneProducer<Cow>, IGrassMuncher<Cow>
    {
        public void Milk() => WriteLine($"{name} has been milked.");
        public Cow(string newName) : base(newName) { }
        public Cow() { }
        public override void MakeANoise() => WriteLine($"{name} says 'moo'!");
    }
}
