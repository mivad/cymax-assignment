using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IPack
    {
        IAddress source { get; set; }
        IAddress destination { get; set; }
        List<IDimension> dimensions { get; set; }
    }
}
