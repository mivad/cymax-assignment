using System;
using System.Collections.Generic;
using System.Text;

namespace Services.API3.Models
{
    public class Address
    {
        public string post { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string city { get; set; }
        public Address(string _post, string _country, string _region, string _city)
        {
            post = _post;
            country = _country;
            region = _region;
            city = _city;
        }
    }
}
