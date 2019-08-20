using Services.API2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.API2.DTOs
{
    public class API2DTO
    {
        public Address consignee { get; set; }
        public Address consignor { get; set; }
        public List<Carton> cartons { get; set; }

        public static API2DTO ConvertToDTO(Implementations.Pack pack)
        {

            if (pack.source == null)
                return null;

            var dto = new API2DTO();

            dto.consignor = new Address(pack.source.post, pack.source.country, pack.source.region, pack.source.city);

            dto.consignee = new Address(pack.destination.post, pack.destination.country, pack.destination.region, pack.destination.city);
   
            dto.cartons = ToADimensionsDTOMap(pack.dimensions);

            return dto;
        }

        public static List<Carton> ToADimensionsDTOMap(List<Interfaces.IDimension> _dimensions)
        {
            var cartons = new List<Carton>();

            foreach (var item in _dimensions)
            {
                cartons.Add(new Carton(item.length, item.width, item.height, item.weight));
            }

            return cartons;
        }
    }
}
