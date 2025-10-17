using System.Collections.Generic;
using RealEstateManagement.Data.Models;

namespace RealEstateManagement.Data.DTOs.Properties.Queries
{
    public class PropertiesGetResponseDto
    {
        public List<PropertyModel> Properties { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
    }
}
