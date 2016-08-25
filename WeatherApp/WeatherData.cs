using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//87d6fc5d9a763fe927bfe1438407929f - api key
namespace WeatherApp
{
    class WeatherData
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

        public void ToString()
        {
            Debug.WriteLine(cityName + ", " + country);
            Debug.WriteLine("Temperature: current: " + temperature + ", max-temp: " + maxTemp + "min-temo: " + minTemp);
            Debug.WriteLine("Humidity: " + humidity);
            Debug.WriteLine("Wind: Speed: " + windSpeed + ", Direction: " + windDirection);
            Debug.WriteLine("Clouds: " + cloud);
            Debug.WriteLine("Sunrise: " + sunrise + ", Sunset: " + sunset);




        }
    }

}
