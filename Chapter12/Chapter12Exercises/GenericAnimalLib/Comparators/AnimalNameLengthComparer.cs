using GenericAnimalLib.Classes;
using System.Collections.Generic;

namespace GenericAnimalLib.Comparators
{
    public class AnimalNameLengthComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y) => x.Name.Length.CompareTo(y.Name.Length);
    }
}
