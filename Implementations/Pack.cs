using Interfaces;
using System;
using System.Collections.Generic;

namespace Implementations
{
    public class Pack : IPack
    {
        public IAddress source { get; set; }
        public IAddress destination { get; set; }
        public List<IDimension> dimensions { get; set; }
    }
}
