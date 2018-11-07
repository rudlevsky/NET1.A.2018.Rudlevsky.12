﻿using System;
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
        public event Action<object, DataEventArgs> NewMail;

        /// <summary>
        /// Generates data and sends it to subscribers after passed time.
        /// </summary>
        public void OnSendMailTimed(int time)
        {
            Timer timer = new Timer(time);

            timer.Elapsed += OnSendMail;
            timer.Enabled = true;
            timer.AutoReset = false;
        }

        /// <summary>
        /// Notifies all subscrbers.
        /// </summary>
        protected virtual void Notify(DataEventArgs info) => 
            NewMail?.Invoke(this, info);

        /// <summary>
        /// Event method for notifying.
        /// </summary>
        public void OnSendMail() => 
            Notify(new DataEventArgs() { Message = ToString()});

        private void OnSendMail(object sender, ElapsedEventArgs arg) => OnSendMail();                
    }
}