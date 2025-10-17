using System;

namespace RealEstateManagement.Data.DTOs.Properties.Create
{
    public class PropertyCreateResponseDto
    {
        public int PropertyId { get; set; }
        public string Location { get; set; }
        public int NumOfRooms { get; set; }
        public string Status { get; set; }
        public string Availability { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal Area { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}