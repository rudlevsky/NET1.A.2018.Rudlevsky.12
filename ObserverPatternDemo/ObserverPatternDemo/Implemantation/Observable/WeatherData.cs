using System;

namespace ObserverPatternDemo.Implemantation.Observable
{
    /// <summary>
    /// Class manages IObserver objects.
    /// </summary>
    public class WeatherData 
    {
        /// <summary>
        /// Contains subscribers methods.
        /// </summary>
        public event EventHandler<WeatherInfoEventArgs> NewMail;

        /// <summary>
        /// Generates data and sends it to subscribers.
        /// </summary>
        public void Generate()
        {
            Random rand = new Random();
            var currentData = new WeatherInfoEventArgs { Temperature = rand.Next(40), Humidity = rand.Next(400, 500), Pressure = rand.Next(990, 1010) };
            OnNewMail(currentData);
        }

        /// <summary>
        /// Notifies all observers.
        /// </summary>
        protected virtual void OnNewMail(WeatherInfoEventArgs info)
        {
            NewMail?.Invoke(this, info);
        }
    }
}