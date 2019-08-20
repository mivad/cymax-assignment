using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementations
{
    public class Dimension : IDimension
    {
        public decimal length { get; set; }
        public decimal width { get; set; }
        public decimal height { get; set; }
        public decimal weight { get; set; }
    }
}
