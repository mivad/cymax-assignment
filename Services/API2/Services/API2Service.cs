using Services.API2.DTOs;
using Services.API2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.API2.Services
{
    public class API2Service
    {
        private static decimal getAmout(Address consignor, Address consignee, List<Carton> cartons)
        {
            //WebMethod
            //resquest get from API 2 to get the price

            return 6.56m;
        }

        public static decimal getAmout(Implementations.Pack packing)
        {
            API2DTO api2 = API2DTO.ConvertToDTO(packing);

            return getAmout(api2.consignor, api2.consignee, api2.cartons);
        }
    }
}
