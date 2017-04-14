using static System.Console;
using System.Timers;

namespace HandlingEvents
{
    class Program
    {
        static int counter = 0;
        static string displayString = "This string will appear one letter at a time.\n";

        static void Main(string[] args)
        {
            Timer myTimer = new Timer(100);
            //Using += operator to subscribe to our event handler via delegates
            //myTimer.Elapsed += new ElapsedEventHandler(WriteChar);
            //Can also use the "method group" sytnax:
            myTimer.Elapsed += WriteChar;
            myTimer.Start();
            System.Threading.Thread.Sleep(200);
            ReadKey();
        }

        /// <summary>
        /// Event handler
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        static void WriteChar(object source, ElapsedEventArgs e)
        {
            Write(displayString[counter++ % displayString.Length]);
        }
    }
}
