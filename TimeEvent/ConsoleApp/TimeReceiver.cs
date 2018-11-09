using TimeEvent.Models;

namespace TimeEvent
{
    /// <summary>
    /// Class for subscribers.
    /// </summary>
    public class TimeReceiver
    {
        /// <summary>
        /// Message from sender.
        /// </summary>
        public string MessageInfo { get; set; } 

        /// <summary>
        /// Subscribes on sender.
        /// </summary>
        /// <param name="sender">Sender for subscribing.</param>
        public void Register(TimeSender sender)
        {
            sender.NewMail += Update;
        }

        /// <summary>
        /// Unsubscribes on sender.
        /// </summary>
        /// <param name="sender">Sender for unsubscribing.</param>
        public void Unregister(TimeSender sender)
        {
            sender.NewMail -= Update;
        }

        /// <summary>
        /// Updates current data.
        /// </summary>
        /// <param name="obj">Sender object.</param>
        /// <param name="data">New data.</param>
        public void Update(object obj, DataEventArgs data)
        {
            MessageInfo = data.Message;
        }
    }
}
