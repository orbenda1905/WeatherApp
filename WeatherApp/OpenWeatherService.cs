using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WeatherApp
{
    public class OpenWeatherService : IWeatherDataService
    {
        string apiKey = "87d6fc5d9a763fe927bfe1438407929f";

        private static OpenWeatherService instance;

        public static OpenWeatherService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OpenWeatherService();
                }
                return instance;
            }
        }
        private OpenWeatherService()
        {
            
        }

        public string ApiKey
        {
            get
            {
                return this.apiKey;
            }
            set
            {
                this.apiKey = value;
            }
        }

        public WeatherData GetWeatherData(Location location)
        {
            var url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=" + location.GetLocation() + "&units=metric&mode=xml&APPID=" + ApiKey);
            var wc = new WebClient();
            
            string reply = wc.DownloadString(url);

            WeatherData weather = new WeatherData();
            XDocument ob;
            try
            {
                ob = XDocument.Parse(reply);
            }
            catch (Exception e)
            {
                throw new WeatherDataServiceException(e.Message + "\nerror: city not found");
            }
            weather.cityName = ob.Root.Element("city").Attribute("name").Value;
            weather.country = ob.Root.Element("city").Element("country").Value;
            weather.id = ob.Root.Element("city").Attribute("id").Value;
            weather.lon = ob.Root.Element("city").Element("coord").Attribute("lon").Value;
            weather.lat = ob.Root.Element("city").Element("coord").Attribute("lat").Value;
            weather.temperature = ob.Root.Element("temperature").Attribute("value").Value;
            weather.maxTemp = ob.Root.Element("temperature").Attribute("max").Value;

            weather.minTemp = ob.Root.Element("temperature").Attribute("min").Value;
            weather.humidity = ob.Root.Element("humidity").Attribute("value").Value + "%";
            weather.windSpeed = ob.Root.Element("wind").Element("speed").Attribute("value").Value;
            weather.windDirection = ob.Root.Element("wind").Element("direction").Attribute("name").Value;
            weather.cloud = ob.Root.Element("clouds").Attribute("name").Value;
            weather.sunrise = ob.Root.Element("city").Element("sun").Attribute("rise").Value.Substring(11);
            weather.sunset = ob.Root.Element("city").Element("sun").Attribute("set").Value.Substring(11);


            return weather;
        }
    }
}
