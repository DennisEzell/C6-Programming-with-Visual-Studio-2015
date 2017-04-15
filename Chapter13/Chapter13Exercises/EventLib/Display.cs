using static System.Console;

namespace EventLib
{
    public class Display
    {
        public void DisplayMessage(object source, MessageArrivedEventArgs e)
        {
            WriteLine($"Message arrived from: {(source as Connection).Name}");
            WriteLine($"Message text: {e.Message}");
        }
    }
}
