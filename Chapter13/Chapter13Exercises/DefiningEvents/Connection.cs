using System;
using System.Timers;
using static System.Console;

namespace DefiningEvents
{
    public delegate void MessageHandler(string message);
    public class Connection
    {
        public event MessageHandler MessageArrived;
        private Timer pollTimer;
        private static Random random = new Random();

        public Connection()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += CheckForMessage;
        }

        public void Connect() => pollTimer.Start();
        public void Disconnect() => pollTimer.Stop();

        /// <summary>
        /// Event handler
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void CheckForMessage(Object source, ElapsedEventArgs e)
        {
            WriteLine("Checking for new Messages");
            if(random.Next(9) == 0 && MessageArrived != null)
            {
                MessageArrived("Hellow World!");
            }
        }
    }
}
