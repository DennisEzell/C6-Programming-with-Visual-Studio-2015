using static System.Console;

namespace ArrayVsCollection.Class
{
    public abstract class Animal
    {
        /// <summary>
        /// Fields
        /// </summary>
        protected string name;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Animal()
        {
            name = "An animal has no name";
        }

        /// <summary>
        /// Single arg name constructor
        /// </summary>
        /// <param name="newName"></param>
        public Animal(string newName)
        {
            name = newName;
        }

        /// <summary>
        /// Property for name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Feed() => WriteLine($"{name} has been fed.");

    }
}
