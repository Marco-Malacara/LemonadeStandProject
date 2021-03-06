﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        private List<string> conditionOfWeather;
        private List<int> tempatureOfDay;
        private List<string> weatherForcast;
        public string condition;
        public int tempature;
        public string conditionForecast;
        public int tempatureForecast;
        Random random = new Random();

        public Weather()
        {
            conditionOfWeather = new List<string>() { "sunny", "raining", "cloudy", "partly cloudy" };
            tempatureOfDay = new List<int>() { 65, 70, 75, 80, 85, 90, 100 };
        }
        
        public void TodaysTemperature()
        {
            int todaysTemperature = random.Next(0, tempatureOfDay.Count);
            tempature = tempatureOfDay[todaysTemperature];
        }

        public void TodaysCondition()
        {
            int todaysCondition = random.Next(0, conditionOfWeather.Count);
            condition = conditionOfWeather[todaysCondition];
        }

        public void GenerateTodaysWeather()
        {
            weatherForcast = new List<string> { "today" };
            foreach (string day in weatherForcast)
            {
                TodaysTemperature();
                TodaysCondition();
            }
        }

        public void DisplayTodaysWeather()
        {
            Console.WriteLine("Today's weather is: {0} {1}", tempature, condition);
        }

        public void ForecastTempature()
        {
             int forecastTempature = random.Next(0, tempatureOfDay.Count);
            tempatureForecast = tempatureOfDay[forecastTempature];
        }

        public void ForecastCondition()
        {
            int forecastCondition = random.Next(0, conditionOfWeather.Count);
            conditionForecast = conditionOfWeather[forecastCondition];
        }

        public void GenerateForecast()
        {
            weatherForcast = new List<string> { "Tomorrow's", "The following day's", "The day after that" };
            foreach(string t in weatherForcast)
            {
                ForecastTempature();
                ForecastCondition();
                Console.WriteLine(t + "forcast is: {0} {1}", tempatureForecast, conditionForecast);
            }
        }
    }
}
