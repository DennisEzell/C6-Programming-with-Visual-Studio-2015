using static System.Console;
namespace HideVsOverride.Class.Override
{
    public class OverrideBase
    {
        /// <summary>
        /// We mark the method as virtual so it can be overridden in the subclass
        /// </summary>
        public virtual void DoSomething()
        {
            WriteLine("\tBASE IMPLEMENTATION: OverrideBase.DoSomething() called\n");
        }
    }
}
