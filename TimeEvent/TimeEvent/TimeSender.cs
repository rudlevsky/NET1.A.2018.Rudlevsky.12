using System;
using TimeEvent.Models;
using System.Timers;

namespace TimeEvent
{
    /// <summary>
    /// Class works with subscribers.
    /// </summary>
    public class TimeSender
    {
        /// <summary>
        /// Contains subscribers methods.
        /// </summary>
        public event EventHandler<DataEventArgs> NewMail;

        /// <summary>
        /// Generates data and sends it to subscribers after passed time.
        /// </summary>
        public void SendMailTimed(int time)
        {
            Timer timer = new Timer(time);

            timer.Elapsed += SendMail;
            timer.Enabled = true;
            timer.AutoReset = false;
        }

        /// <summary>
        /// Notifies all subscrbers.
        /// </summary>
        protected virtual void OnNewMail(DataEventArgs info) => 
            NewMail?.Invoke(this, info);

        /// <summary>
        /// Event method for notifying.
        /// </summary>
        public void SendMail() =>
            OnNewMail(new DataEventArgs() { Message = ToString()});

        private void SendMail(object sender, ElapsedEventArgs arg) => SendMail();                
    }
}
