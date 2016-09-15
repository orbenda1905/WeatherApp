using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherDataServiceFactory serviceFactory = new WeatherDataServiceFactory();
            IWeatherDataService newService = serviceFactory.GetWeatherDataService(dataServices.OPEN_WEATHER_MAP);
            var url = String.Format("http://api.openweathermap.org/data/2.5/weather?q=London,uk&units=metric&mode=xml&APPID=87d6fc5d9a763fe927bfe1438407929f");
            var wc = new WebClient();
            string reply = wc.DownloadString(url);
            Debug.WriteLine(reply);

            XDocument ob = XDocument.Parse(reply);
            var cityName = ob.Root.Element("city").Attribute("name").Value;
            var temperature = ob.Root.Element("temperature").Attribute("value").Value;
            var maxTemp = ob.Root.Element("temperature").Attribute("max").Value;
            var minTemp = ob.Root.Element("temperature").Attribute("min").Value;
            var humidity = ob.Root.Element("humidity").Attribute("value").Value + "%";
            var windSpeed = ob.Root.Element("wind").Element("speed").Attribute("value").Value;
            var windDirection = ob.Root.Element("wind").Element("direction").Attribute("name").Value;
            var cloud = ob.Root.Element("clouds").Attribute("name").Value;
            var sunrise = ob.Root.Element("city").Element("sun").Attribute("rise").Value.Substring(11);
            var sunset = ob.Root.Element("city").Element("sun").Attribute("set").Value.Substring(11);
            var country = ob.Root.Element("city").Element("country").Value;


            //var data = from x in ob.Descendants("current") select new

            Debug.WriteLine("=======================================");
            Debug.WriteLine(sunrise);
            Debug.WriteLine(sunset);


            //var stream = wc.OpenRead(url);
            //Console.WriteLine(stream);
            Console.ReadLine();
        }
    }
}
