using Implementations;
using Interfaces;
using Services.API1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.API1.DTOs
{
    public class API1DTO
    {
        public Contact contact { get; set; }
        public Warehouse warehouse { get; set; }
        public List<Models.Dimension> dimensions { get; set; }

        public static API1DTO ConvertToDTO(Pack pack)
        {

            if (pack.source == null || pack.destination == null)
                return null;

            var dto = new API1DTO();

            dto.warehouse = new Warehouse();
            dto.warehouse.companyName = pack.source.name;
            dto.warehouse.address = new Models.Address();
            dto.warehouse.address.city = pack.source.city;
            dto.warehouse.address.region = pack.source.region;
            dto.warehouse.address.country = pack.source.country;
            dto.warehouse.address.post = pack.source.post;



            dto.contact = new Contact();
            dto.contact.fullName = pack.destination.name;
            dto.contact.address = new Models.Address();
            dto.contact.address.city = pack.destination.city;
            dto.contact.address.region = pack.destination.region;
            dto.contact.address.country = pack.destination.country;
            dto.contact.address.post = pack.destination.post;

            dto.dimensions = ToADimensionsDTOMap(pack.dimensions);

            /*
            return new API1DTO {
                contact = {
                    fullName = pack.source.name,
                    address = {
                        city = pack.source.city,
                        region = pack.source.region,
                        country = pack.source.country,
                        post = pack.source.post,
                    }
                },
                warehouse = {
                    companyName = pack.destination.name,
                    address = {
                        city = pack.source.city,
                        region = pack.source.region,
                        country = pack.source.country,
                        post = pack.source.post,
                    }
                },
                dimensions = ToADimensionsDTOMap(pack.dimensions)
            };*/

            return dto;
        }

        public static List<Models.Dimension> ToADimensionsDTOMap(List<IDimension> _dimensions)
        {
            var dimensions = new List<Models.Dimension>();

            foreach (var item in _dimensions)
            {
                dimensions.Add(new Models.Dimension(item.length, item.width, item.height, item.weight));
            }

            return dimensions;
        }
    }
}
