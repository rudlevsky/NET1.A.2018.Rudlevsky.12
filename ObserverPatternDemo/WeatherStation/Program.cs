﻿using ObserverPatternDemo.Implemantation.Observable;
using ObserverPatternDemo.Implemantation.Observers;
using System;
using System.Threading;

namespace WeatherStation
{
    public class Program
    {
        private static WeatherData weather;
        private static StatisticReport statistic;
        private static CurrentConditionsReport current;

        // Gets reports from subscribers.
        private static void GetReports()
        {
            int count = 0;

            while(count < 5)
            {
                weather.Generate();

                Console.WriteLine(current.GetReport());
                string[] stat = statistic.GetStatisticReport();

                Console.WriteLine();

                foreach (var report in stat)
                {
                    Console.WriteLine(report);
                }

                Console.WriteLine();

                Thread.Sleep(1000);
                count++;
            }
        }

        private static void Main(string[] args)
        {
            weather = new WeatherData();
            statistic = new StatisticReport();
            current = new CurrentConditionsReport();

            statistic.Register(weather);
            current.Register(weather);
            GetReports();
        }
    }
}
