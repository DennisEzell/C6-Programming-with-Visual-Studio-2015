using EventLib;
using static System.Console;

namespace DefiningEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection myConnection = new Connection("Connection 1");
            Display myDisplay = new Display();

            myConnection.MessageArrived += myDisplay.DisplayMessage;
            myConnection.Connect();
            ReadKey();
        }
    }
}
