using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericAnimalLib
{
    /// <summary>
    /// You implement IEnumerable<T> to make it possible to iterate through the items
    /// contain in Farm<T> without needing to explictly iterate over Farm<T>.Animals
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Farm<T> : IEnumerable<T> where T : Animal
    {

        private List<T> animals = new List<T>();

        public List<T> Animals { get { return animals; } }

        public void Add(T animal) => animals.Add(animal);       

        /// <summary>
        /// In order iterate over the items in Farm<T> without iterating over Farm<T>.Animals,
        /// we have to return the enumerator exposed by Animals
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator() => animals.GetEnumerator();

        /// <summary>
        /// Because IEnumerable<T> inherits from IEnumerable, we also implement 
        /// IEnumerable.GetEnumerator()
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator() => animals.GetEnumerator();

        public void MakeNoises() => animals.ForEach(a => a.MakeANoise());

        public void FeedTheAnimals() => animals.ForEach(a => a.Feed());

        public Farm<Cow> GetCows() => new Farm<Cow> { animals = Animals.FindAll(a => a is Cow).Cast<Cow>().ToList() };

        /// <summary>
        /// Generic Method for retrieving any type of animal in the farm,
        /// not just cows as the method above.
        /// 
        /// We specify the return type U to be constrained by type T.
        /// This means if we call using Farm.GetSpecies<Chicken>(), we are
        /// saying U=Chicken and that is contrained by T=Animal
        /// </summary>
        /// <returns></returns>
        public Farm<U> GetSpecies<U>() where U : T => new Farm<U> { animals = Animals.FindAll(a => a is U).Cast<U>().ToList() };
    }
}
