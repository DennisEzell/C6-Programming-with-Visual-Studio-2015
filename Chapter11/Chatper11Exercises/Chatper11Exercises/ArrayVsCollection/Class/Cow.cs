using static System.Console;

namespace ArrayVsCollection.Class
{
    public class Cow : Animal
    {
        public void Milk() => WriteLine($"{name} has been milked.");

        public Cow(string newName) : base(newName) { }
    }
}
