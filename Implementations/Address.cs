using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementations
{
    public class Address : IAddress
    {
        public string name { get; set; }
        public string post { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string city { get; set; }

        public Address(string _name, string _post, string _country, string _region, string _city)
        {
            name = _name;
            post = _post;
            country = _country;
            region = _region;
            city = _city;
        }
    }
}
