
using AnimalLib.Class;
using System.Collections;

namespace AnimalLib.Collection
{
    public class AnimalDictionary : DictionaryBase
    {
        public void Add(string newID, Animal newAnimal)
        {
            Dictionary.Add(newID, newAnimal);
        }

        public void Remove(string animalID)
        {
            Dictionary.Remove(animalID);
        }

        public Animal this[string animalID]
        {
            get { return (Animal)Dictionary[animalID]; }
            set { Dictionary[animalID] = value; }
        }

        /// <summary>
        /// Hide the base implementation of GetEnumerator() - use 'new' keyword
        /// </summary>
        /// <returns></returns>
        public new IEnumerable GetEnumerator()
        {
            foreach (object animal in Dictionary.Values)
            {
                yield return (Animal)animal;
            }
        }
    }
}
