using RealEstateManagement.Data.Models;
using System.Collections.Generic;



namespace RealEstateManagement.Data.DTOs.Clients.Queries
{
    public class ClientPropertiesGetResponseDto
    {
        public List<ClientPropertyModel> Properties { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
    }
}
