using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateManagement.Data.Models;
namespace RealEstateManagement.Data.DTOs.Owners.Queries
{
    public class OwnerPropertiesGetResponseDto
    {
        public List<OwnerPropertyModel> Properties { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
    }
}
