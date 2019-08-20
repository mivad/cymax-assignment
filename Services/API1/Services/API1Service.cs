using Services.API1.DTOs;
using Services.API1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.API1.Services
{
    public class API1Service
    {
        private static decimal getTotal(Contact contact, Warehouse warehouse, List<Dimension> dimensions)
        {
            //resquest get from API 1 to get the price
            //using HttpWebRequest?

            return 10;
        }

        public static decimal getTotal(Implementations.Pack packing)
        {
            API1DTO api1 = API1DTO.ConvertToDTO(packing);

            return getTotal(api1.contact, api1.warehouse, api1.dimensions);
        }
    }
}
