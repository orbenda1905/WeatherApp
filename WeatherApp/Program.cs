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
            Location location = new Location("London", "uk");
            WeatherData data = newService.GetWeatherData(location);
            Debug.WriteLine(data.ToString());

            Console.ReadLine();
        }
    }
}
