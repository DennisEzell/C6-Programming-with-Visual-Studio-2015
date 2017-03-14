using AnimalLib.Class;
using System.Collections;

namespace AnimalLib.Collection
{
    public class Animals : CollectionBase
    {
        /// <summary>
        /// Add method
        /// </summary>
        /// <param name="newAnimal"></param>
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }

        /// <summary>
        /// Remove method
        /// </summary>
        /// <param name="oldAnimal"></param>
        public void Remove(Animal oldAnimal)
        {
            List.Remove(oldAnimal);
        }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="animalIndex"></param>
        /// <returns>Animal object at specified index</returns>
        public Animal this[int animalIndex]
        {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
}
