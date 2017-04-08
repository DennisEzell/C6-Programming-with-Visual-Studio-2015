using static System.Console;

namespace GenericAnimalLib
{
    public class Cow : Animal
    {
        public void Milk() => WriteLine($"{name} has been milked.");
        public Cow(string newName) : base(newName) { }
        public override void MakeANoise() => WriteLine($"{name} says 'moo'!");
    }
}
