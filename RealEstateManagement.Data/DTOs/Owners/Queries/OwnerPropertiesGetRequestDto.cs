using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagement.Data.DTOs.Owners.Queries
{
    public class OwnerPropertiesGetRequestDto
    {
        public int OwnerId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}
