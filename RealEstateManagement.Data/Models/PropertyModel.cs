using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagement.Data.Models
{
    public class PropertyModel
    {
        public int PropertyId { get; set; }
        public string Location { get; set; }
        public int NumOfRooms { get; set; }
        public string Status { get; set; }
        public string Availability { get; set; }
        public decimal Price { get; set; }
        public decimal Area { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
