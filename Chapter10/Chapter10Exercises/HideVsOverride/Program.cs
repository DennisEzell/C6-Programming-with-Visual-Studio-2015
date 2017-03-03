
using HideVsOverride.Class.Override;
using HideVsOverride.Class.Hide;
using static System.Console;

namespace HideVsOverride
{
    class Program
    {
        /// <summary>
        /// If you override the base class method, you will always use the derived class implementation
        /// If you hide the base class method, you will use the method implementation depending on the variable type 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            HideDerived hideSubClass = new HideDerived();
            HideBase hideBaseClass;
            hideBaseClass = hideSubClass;

            Write("Calling from Base Class reference:   ");
            hideBaseClass.DoSomething();
            Write("\nCalling from Sub Class reference: ");
            hideSubClass.DoSomething();

            OverrideDerive overrideSubClass = new OverrideDerive();
            OverrideBase overrideBaseClass;
            overrideBaseClass = overrideSubClass;

            Write("\nCalling from Base Class reference:   ");
            overrideBaseClass.DoSomething();
            Write("\nCalling from Sub Class reference: ");
            overrideSubClass.DoSomething();

            ReadKey();

        }
    }
}
