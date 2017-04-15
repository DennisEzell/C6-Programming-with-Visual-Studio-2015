using EventLib;
using static System.Threading.Thread;
using static System.Console;

namespace MultiPurposeEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection conn1 = new Connection("First Connection");
            Connection conn2 = new Connection("Second Connection");
            Display display = new Display();
            conn1.MessageArrived += display.DisplayMessage;
            conn2.MessageArrived += display.DisplayMessage;

            conn1.Connect();
            conn2.Connect();

            Sleep(200);
            ReadKey();
        }
    }
}
