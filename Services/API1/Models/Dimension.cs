using System;
using System.Collections.Generic;
using System.Text;

namespace Services.API1.Models
{
    public class Dimension
    {
        public decimal length { get; set; }
        public decimal width { get; set; }
        public decimal height { get; set; }
        public decimal weight { get; set; }

        public Dimension(decimal _length, decimal _width, decimal _height, decimal _weight)
        {
            length = _length;
            width = _width;
            height = _height;
            weight = _weight;
        }
    }
}
