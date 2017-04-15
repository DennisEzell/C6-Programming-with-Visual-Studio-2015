using System;
using System.Timers;
using static System.Console;

namespace EventLib
{
    //public delegate void MessageHandler(string message);
    public class Connection
    {
        public event EventHandler<MessageArrivedEventArgs> MessageArrived;
        private Timer pollTimer;
        private static Random random = new Random();
        public string Name { get; set; }

        public Connection()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += CheckForMessage;
        }

        public Connection(string newName) : this()
        {
            Name = newName;
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
            //MessageArrived will be null UNLESS it has a subscriber.
            //We only want to raise the event if there is a subscriber.
            if(random.Next(9) == 0 && MessageArrived != null)
            {
                MessageArrived(this, new MessageArrivedEventArgs("Hellow World!"));
            }
        }
    }
}
