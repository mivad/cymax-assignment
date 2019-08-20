using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IAddress
    {
        string name { get; set; }
        string post { get; set; }
        string country { get; set; }
        string region { get; set; }
        string city { get; set; }
    }   
}
