using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IDimension
    {
        decimal length { get; set; }
        decimal width { get; set; }
        decimal height { get; set; }
        decimal weight { get; set; }
    }
}
