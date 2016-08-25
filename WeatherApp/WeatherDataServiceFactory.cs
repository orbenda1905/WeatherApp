using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{

    class WeatherDataServiceFactory
    {
        public WeatherDataServiceFactory() { }

        public IWeatherDataService GetWeatherDataService(dataServices service)
        {
            switch (service)
            {
                case dataServices.OPEN_WEATHER_MAP:
                    return OpenWeatherService.Instance;
                default:
                    return OpenWeatherService.Instance;//because we don'w use another service
            }
        }
    }

    public enum dataServices{
        OPEN_WEATHER_MAP
    }
}
