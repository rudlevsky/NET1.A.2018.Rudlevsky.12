using System;

namespace ObserverPatternDemo.Implemantation.Observable
{
    public class WeatherInfoEventArgs : EventArgs
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
    }
}