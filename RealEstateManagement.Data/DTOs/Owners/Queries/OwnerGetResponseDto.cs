using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagement.Data.DTOs.Owners.Queries
{
    public class OwnerGetResponseDto
    {
        public int OwnerId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
