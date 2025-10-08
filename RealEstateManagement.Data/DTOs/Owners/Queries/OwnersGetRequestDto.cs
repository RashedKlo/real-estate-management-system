using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagement.Data.DTOs.Owners.Queries
{
    public class OwnersGetRequestDto
    {
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 10;
    }
}
