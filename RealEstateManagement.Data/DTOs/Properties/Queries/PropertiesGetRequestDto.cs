namespace RealEstateManagement.Data.DTOs.Properties.Queries
{
    public class PropertiesGetRequestDto
    {
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 10;

        // Filter parameters
        public string Location { get; set; }
        public int? NumOfRooms { get; set; }
        public string Status { get; set; }
        public string Availability { get; set; }
        public decimal? PriceFrom { get; set; }
        public decimal? PriceTo { get; set; }
        public decimal? AreaFrom { get; set; }
        public decimal? AreaTo { get; set; }
    }
}
