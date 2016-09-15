using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeatherApp
{
    public class WeatherData
    {
        public string cityName;
        public string temperature;
        public string maxTemp;
        public string minTemp;
        public string humidity;
        public string windSpeed;
        public string windDirection;
        public string cloud;
        public string sunrise;
        public string sunset;
        public string country;

        public WeatherData() { }

        override
        public string ToString()
        {
            string data = @"weather data:" + "\n" +
                            cityName + ", " + country
                          + "\nTemperature: current = " + temperature + (char)176 + ", max-temp = " + maxTemp + (char)176 + " min-temp = " + minTemp + (char)176
                          + "\nHumidity: " + humidity
                          + "\nWind: Speed = " + windSpeed + ", Direction = " + windDirection
                          + "\nClouds: " + cloud
                          + "\nSunrise: " + sunrise
                          + "\nSunset: " + sunset;

            return data;
        }
    }
}
