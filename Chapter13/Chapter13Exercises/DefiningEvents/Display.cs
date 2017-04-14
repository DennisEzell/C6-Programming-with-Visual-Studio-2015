using static System.Console;

namespace DefiningEvents
{
    public class Display
    {
        public void DisplayMessage(string message) => WriteLine($"Message arrived: {message}");
    }
}
