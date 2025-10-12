using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagement.Data.Models
{
    public class OwnerPropertyModel
    {
        public int PropertyId { get; set; }
        public string Location { get; set; }
        public int NumOfRooms { get; set; }
        public string Status { get; set; }
        public string Availability { get; set; }
        public decimal? RentPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? MortgagePrice { get; set; }
        public int OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
