using System;
using System.Collections.Generic;
using System.Text;
using Services.API3.Models;

namespace Services.API3.DTOs
{
    public class API3DTO
    {
        public Address source { get; set; }
        public Address destination { get; set; }
        public List<Package> packages { get; set; }

        public static API3DTO ConvertToDTO(Implementations.Pack pack)
        {

            if (pack.source == null)
                return null;

            var dto = new API3DTO();

            dto.source = new Address(pack.source.post, pack.source.country, pack.source.region, pack.source.city);

            dto.destination = new Address(pack.destination.post, pack.destination.country, pack.destination.region, pack.destination.city);

            dto.packages = ToADimensionsDTOMap(pack.dimensions);

            return dto;
        }

        public static List<Package> ToADimensionsDTOMap(List<Interfaces.IDimension> _dimensions)
        {
            var cartons = new List<Package>();

            foreach (var item in _dimensions)
            {
                cartons.Add(new Package(item.length, item.width, item.height, item.weight));
            }

            return cartons;
        }
    }
}
