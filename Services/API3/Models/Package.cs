using System;
using System.Collections.Generic;
using System.Text;

namespace Services.API3.Models
{
    public class Package
    {
        public decimal length { get; set; }
        public decimal width { get; set; }
        public decimal height { get; set; }
        public decimal weight { get; set; }
        public string weightUnit { get; set; }
        public List<string> tags { get; set; }

        public Package(decimal _length, decimal _width, decimal _height, decimal _weight)
        {
            length = _length;
            width = _width;
            height = _height;
            weight = _weight;
        }
    }
}
