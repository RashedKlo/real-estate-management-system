using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagement.Data.DTOs.Clients.Queries
{
    public class ClientsGetRequestDto
    {
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 10;
    }
}
