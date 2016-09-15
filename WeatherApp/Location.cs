using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeatherApp
{
    public class Location
    {

        private string city;
        private string country;

        public Location(string city, string country)
        {
            City = city;
            if (country != null)
            {
                Country = country;
            }
            
        }

        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
            }
        }
        public string GetLocation()
        {

            return this.City + "," + this.Country;
        }
    }
}
