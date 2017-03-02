using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsMethodsProperties
{
    public class MyClass
    {   
        /// <summary>
        /// Constructors
        /// </summary>
        private MyClass() : this("Default Name") { }
        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
            myDoubledInt = 5;
        }

        /// <summary>
        /// Fields
        /// </summary>
        public readonly string Name;
        private int intVal;
        private int myDoubledInt;

        /// <summary>
        /// Properties
        /// </summary>
        public int MyDoubledIntProp => (myDoubledInt * 2);
        public int Val
        {
            get { return intVal; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    intVal = value;
                }
                else
                {
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10."));
                }
            }
        }

        /// <summary>
        /// Methods
        /// </summary>
        public override string ToString() => $"Name: {Name}\nVal: {Val}";



    }
}
