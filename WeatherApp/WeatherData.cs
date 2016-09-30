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
        public string country;
        public string id;
        public string lon;
        public string lat;
        public string temperature;
        public string maxTemp;
        public string minTemp;
        public string humidity;
        public string windSpeed;
        public string windDirection;
        public string cloud;
        public string sunrise;
        public string sunset;
        

        public WeatherData() { }

        override
        public string ToString()
        {
            string data = "weather data:" + "\n" +
                            cityName + ", " + country
                          + "\nId = " + id + ", lon = " + lon + ", lat = " + lat
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
