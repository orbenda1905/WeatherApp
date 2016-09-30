using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Tests
{
    [TestClass()]
    public class OpenWeatherServiceTests
    {
        [TestMethod()]
        public void GetWeatherDataTest()
        {
            OpenWeatherService openWeatherService = OpenWeatherService.Instance;
            Location location = new Location("tel Aviv", "IL");
            WeatherData result = openWeatherService.GetWeatherData(location);

            WeatherData currectwWeatherData = new WeatherData();
            currectwWeatherData.cityName = "Tel Aviv";
            currectwWeatherData.country = "IL";
            currectwWeatherData.id = "293397";
            currectwWeatherData.lon = "34.78";
            currectwWeatherData.lat = "32.08";

            Assert.IsNotNull(result);
            Assert.AreEqual(currectwWeatherData.cityName, result.cityName);
            Assert.AreEqual(currectwWeatherData.country, result.country);
            Assert.AreEqual(currectwWeatherData.lon, result.lon);
            Assert.AreEqual(currectwWeatherData.lat, result.lat);
            Assert.AreEqual(currectwWeatherData.id, result.id);
        }
    }
}