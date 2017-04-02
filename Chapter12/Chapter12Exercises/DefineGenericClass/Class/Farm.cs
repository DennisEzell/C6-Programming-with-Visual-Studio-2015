using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DefineGenericClass.Class
{
    public class Farm<T> : IEnumerable<T> where T : Animal
    {

        private List<T> animals = new List<T>();

        public List<T> Animals { get { return animals; } }

        public void Add(T animal) => animals.Add(animal);       

        public IEnumerator<T> GetEnumerator() => animals.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => animals.GetEnumerator();

        public void MakeNoises() => animals.ForEach(a => a.MakeANoise());

        public void FeedTheAnimals() => animals.ForEach(a => a.Feed());

        public Farm<Cow> GetCows() => new Farm<Cow> { animals = Animals.FindAll(a => a is Cow).Cast<Cow>().ToList() };
    }
}
