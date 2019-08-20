using Services.API3.DTOs;
using Services.API3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.API3.Services
{
    public class API3Service
    {
        private static decimal getQuote(Address source, Address destination, List<Package> packages)
        {
            //WebMethod
            //resquest get from API 3 to get the price

            return 13.34m;
        }

        public static decimal getQuote(Implementations.Pack packing)
        {
            API3DTO api3 = API3DTO.ConvertToDTO(packing);

            return getQuote(api3.source, api3.destination, api3.packages);
        }
    }
}
