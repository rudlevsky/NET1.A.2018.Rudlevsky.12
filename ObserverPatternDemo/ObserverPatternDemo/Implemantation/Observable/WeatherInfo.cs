﻿using System;

namespace ObserverPatternDemo.Implemantation.Observable
{
    public class WeatherInfo : EventArgs
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
    }
}