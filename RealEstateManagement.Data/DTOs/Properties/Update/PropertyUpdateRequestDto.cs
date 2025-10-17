using System;

namespace RealEstateManagement.Data.DTOs.Properties.Update
{
    public class PropertyUpdateRequestDto
    {
        public int PropertyId { get; set; }
        public string Location { get; set; }
        public int? NumOfRooms { get; set; }
        public string Status { get; set; }
        public string Availability { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public decimal? Area { get; set; }
    }
}