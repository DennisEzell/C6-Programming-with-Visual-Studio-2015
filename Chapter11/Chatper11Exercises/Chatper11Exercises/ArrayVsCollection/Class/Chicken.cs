using static System.Console;

namespace ArrayVsCollection.Class
{
    public class Chicken : Animal
    {
        public void LayEgg() => WriteLine($"{name} has laid an egg");

        public Chicken(string newName) : base(newName) { }
    }
}
