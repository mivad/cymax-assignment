using Implementations;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class PackService
    {
        public static decimal getTheLowestOffer(Pack pack)
        {
            decimal lowest = decimal.MaxValue;

            decimal api1_total = Services.API1.Services.API1Service.getTotal(pack);
            if (api1_total < lowest)
                lowest = api1_total;

            decimal api2_total = Services.API2.Services.API2Service.getAmout(pack);
            if (api2_total < lowest)
                lowest = api2_total;

            decimal api3_total = Services.API3.Services.API3Service.getQuote(pack);

            if (api3_total < lowest)
                lowest = api3_total;

            return lowest;
        }
    }
}
