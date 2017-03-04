
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
            HideDeriveCallBase hidSubClass2 = new HideDeriveCallBase();
            HideDerived hideSubClass = new HideDerived();
            HideBase hideBaseClass;
            hideBaseClass = hideSubClass;

            Write("Calling from Base Class reference: \n");
            hideBaseClass.DoSomething();
            Write("Calling from Sub Class reference: \n");
            hideSubClass.DoSomething();

            Write("Calling form a Sub class refernce, but using base.DoSomething() to call base class implementation: \n");
            hidSubClass2.DoSomething();

            OverrideDerive overrideSubClass = new OverrideDerive();
            OverrideBase overrideBaseClass;
            overrideBaseClass = overrideSubClass;

            Write("\nCalling from Base Class reference: \n");
            overrideBaseClass.DoSomething();
            Write("\nCalling from Sub Class reference: \n");
            overrideSubClass.DoSomething();

            ReadKey();

        }
    }
}
