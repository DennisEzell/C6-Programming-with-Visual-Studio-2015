using static System.Console;
namespace HideVsOverride.Class.Override
{
    public class OverrideDerive : OverrideBase
    {
        public override void DoSomething()
        {
            WriteLine("DERIVED IMPLEMENTATION: OverrideDerive.DoSomething() called");
        }
    }
}
