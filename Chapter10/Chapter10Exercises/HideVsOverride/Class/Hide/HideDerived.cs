using static System.Console;
namespace HideVsOverride.Class.Hide
{
    public class HideDerived : HideBase
    {
        /// <summary>
        ///  Use of the 'new' keyword 'hides' the HideBase.DoSomething() implementation
        /// </summary>
        new public void DoSomething()
        {
            WriteLine("DERIVED IMPLEMENTATION: HideDerived.DoSomething() called");
        }
    }
}
