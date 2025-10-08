using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagement.Data.DTOs.Clients.Queries
{
    public class ClientPropertiesGetRequestDto
    {
        public int ClientId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}
