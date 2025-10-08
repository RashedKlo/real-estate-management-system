using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagement.Data.Models
{
    public class ClientPropertyModel
    {
        public int ClientPropertyId { get; set; }
        public int ClientId { get; set; }
        public int PropertyId { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }

        // Client Info
        public string ClientFullName { get; set; }
        public string ClientPhoneNumber { get; set; }
        public string ClientAddress { get; set; }

        // Property Info
        public string PropertyLocation { get; set; }
        public int NumOfRooms { get; set; }
        public string PropertyStatus { get; set; }
        public string PropertyAvailability { get; set; }
        public decimal? RentPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? MortgagePrice { get; set; }

        // Owner Info
        public int OwnerId { get; set; }
        public string OwnerFullName { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public string OwnerAddress { get; set; }
    }
}
