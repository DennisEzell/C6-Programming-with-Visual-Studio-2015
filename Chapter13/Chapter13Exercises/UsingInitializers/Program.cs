using GenericAnimalLib.Classes;
using static System.Console;

namespace UsingInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm<Animal> farm = new Farm<Animal>
            {
                new Cow { Name = "Lea" },
                new Chicken { Name = "Noa" },
                new Chicken (),
                new SuperCow { Name = "Lenny"}
            };

            farm.MakeNoises();
            ReadKey();
        }
    }
}
