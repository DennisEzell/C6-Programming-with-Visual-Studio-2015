using static System.Console;

namespace DefiningEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection myConnection = new Connection();
            Display myDisplay = new Display();

            myConnection.MessageArrived += myDisplay.DisplayMessage;
            myConnection.Connect();
            ReadKey();
        }
    }
}
