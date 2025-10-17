using System;

namespace RealEstateManagement.Data.DTOs.Properties.Create
{
    public class PropertyCreateRequestDto
    {
        // Property parameters
        public string Location { get; set; }
        public int NumOfRooms { get; set; }
        public string Status { get; set; }
        public string Availability { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal Area { get; set; }

        // Owner parameters (optional if OwnerId is provided)
        public int? OwnerId { get; set; }
        public string OwnerFullName { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public string OwnerAddress { get; set; }
    }
}