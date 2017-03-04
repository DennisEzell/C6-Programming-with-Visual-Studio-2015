using static System.Console;
namespace HideVsOverride.Class.Hide
{
    public class HideDeriveCallBase : HideBase
    {
        /// <summary>
        ///  Use of the 'new' keyword 'hides' the HideBase.DoSomething() implementation
        /// </summary>
        new public void DoSomething()
        {
            WriteLine("\tDERIVED IMPLEMENTATION: HideDerived.DoSomething() called and calling base.DoSomething\n");
            base.DoSomething();
        }
    }
}
