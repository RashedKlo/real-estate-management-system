using System;
using System.Data.SqlClient;
using RealEstateManagement.Data.DTOs.Properties.Create;
using RealEstateManagement.Data.DTOs.Properties.Update;
using RealEstateManagement.Data.DTOs.Properties.Delete;
using RealEstateManagement.Data.DTOs.Properties.Queries;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Models;

namespace RealEstateManagement.Data.Repositories.Properties.Helpers
{
    public static class PropertyMapper
    {
        // ---------------------- Property Create Mapper ----------------------
        public static PropertyCreateResponseDto MapCreateResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new PropertyCreateResponseDto
            {
                PropertyId = reader.GetValue<int>("PropertyId"),
                Location = reader.GetValue<string>("Location"),
                NumOfRooms = reader.GetValue<int>("NumOfRooms"),
                Status = reader.GetValue<string>("Status"),
                Availability = reader.GetValue<string>("Availability"),
                OwnerId = reader.GetValue<int>("OwnerId"),
                OwnerName = reader.GetValue<string>("OwnerName"),
                OwnerPhone = reader.GetValue<string>("OwnerPhone"),
                Price = reader.GetValue<decimal>("Price"),
                Description = reader.GetValueOrDefault<string>("Description"),
                Area = reader.GetValue<decimal>("Area"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        // ---------------------- Property Update Mapper ----------------------
        public static PropertyUpdateResponseDto MapUpdateResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new PropertyUpdateResponseDto
            {
                PropertyId = reader.GetValue<int>("PropertyId"),
                Location = reader.GetValue<string>("Location"),
                NumOfRooms = reader.GetValue<int>("NumOfRooms"),
                Status = reader.GetValue<string>("Status"),
                Availability = reader.GetValue<string>("Availability"),
                OwnerId = reader.GetValue<int>("OwnerId"),
                OwnerName = reader.GetValue<string>("OwnerName"),
                OwnerPhone = reader.GetValue<string>("OwnerPhone"),
                OwnerAddress = reader.GetValue<string>("OwnerAddress"),
                Price = reader.GetValue<decimal>("Price"),
                Description = reader.GetValueOrDefault<string>("Description"),
                Area = reader.GetValue<decimal>("Area"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        // ---------------------- Property Delete Mapper ----------------------
        public static PropertyDeleteResponseDto MapDeleteResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new PropertyDeleteResponseDto
            {
                PropertyId = reader.GetValue<int>("PropertyId")
            };
        }

        // ---------------------- Single Property Mapper ----------------------
        public static PropertyGetResponseDto MapGetResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new PropertyGetResponseDto
            {
                PropertyId = reader.GetValue<int>("PropertyId"),
                Location = reader.GetValue<string>("Location"),
                NumOfRooms = reader.GetValue<int>("NumOfRooms"),
                Status = reader.GetValue<string>("Status"),
                Availability = reader.GetValue<string>("Availability"),
                OwnerId = reader.GetValue<int>("OwnerId"),
                OwnerName = reader.GetValue<string>("OwnerName"),
                OwnerPhone = reader.GetValue<string>("OwnerPhone"),
                OwnerAddress = reader.GetValue<string>("OwnerAddress"),
                Price = reader.GetValue<decimal>("Price"),
                Description = reader.GetValueOrDefault<string>("Description"),
                Area = reader.GetValue<decimal>("Area"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        // ---------------------- List Property Mapper ----------------------
        public static PropertyModel MapPropertyFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new PropertyModel
            {
                PropertyId = reader.GetValue<int>("PropertyId"),
                Location = reader.GetValue<string>("Location"),
                NumOfRooms = reader.GetValue<int>("NumOfRooms"),
                Status = reader.GetValue<string>("Status"),
                Availability = reader.GetValue<string>("Availability"),
                Price = reader.GetValue<decimal>("Price"),
                Area = reader.GetValue<decimal>("Area"),
                OwnerName = reader.GetValue<string>("OwnerName"),
                OwnerPhone = reader.GetValue<string>("OwnerPhone"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }
    }
}