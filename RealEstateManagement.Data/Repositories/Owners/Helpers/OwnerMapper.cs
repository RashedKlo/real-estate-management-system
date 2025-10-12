using System;
using System.Data.SqlClient;
using RealEstateManagement.Data.DTOs.Owners.Create;
using RealEstateManagement.Data.DTOs.Owners.Update;
using RealEstateManagement.Data.DTOs.Owners.Delete;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Models;

namespace RealEstateManagement.Data.Repositories.Owner.Helpers
{
    public static class OwnerMapper
    {
        // ---------------------- Owner Property Mapper ----------------------
        public static OwnerPropertyModel MapOwnerPropertyFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new OwnerPropertyModel
            {
                PropertyId = reader.GetValueOrDefault<int>("PropertyId"),
                Location = reader.GetValueOrDefault<string>("Location"),
                NumOfRooms = reader.GetValueOrDefault<int>("NumOfRooms"),
                Status = reader.GetValueOrDefault<string>("Status"),
                Availability = reader.GetValueOrDefault<string>("Availability"),
                RentPrice = reader.GetValueOrDefault<decimal?>("RentPrice"),
                SalePrice = reader.GetValueOrDefault<decimal?>("SalePrice"),
                MortgagePrice = reader.GetValueOrDefault<decimal?>("MortgagePrice"),
                OwnerId = reader.GetValueOrDefault<int>("OwnerId"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        // ---------------------- Owner Create Mapper ----------------------
        public static OwnerCreateResponseDto MapCreateResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new OwnerCreateResponseDto
            {
                OwnerId = reader.GetValue<int>("OwnerId"),
                FullName = reader.GetValue<string>("FullName"),
                PhoneNumber = reader.GetValue<string>("PhoneNumber"),
                Address = reader.GetValue<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        // ---------------------- Owner Update Mapper ----------------------
        public static OwnerUpdateResponseDto MapUpdateResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new OwnerUpdateResponseDto
            {
                OwnerId = reader.GetValue<int>("OwnerId"),
                FullName = reader.GetValueOrDefault<string>("FullName"),
                PhoneNumber = reader.GetValueOrDefault<string>("PhoneNumber"),
                Address = reader.GetValueOrDefault<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        // ---------------------- Owner Delete Mapper ----------------------
        public static OwnerDeleteResponseDto MapDeleteResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new OwnerDeleteResponseDto
            {
                OwnerId = reader.GetValue<int>("OwnerId"),
                FullName = reader.GetValue<string>("FullName"),
                PhoneNumber = reader.GetValue<string>("PhoneNumber"),
                Address = reader.GetValue<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        // ---------------------- Single Owner Mapper ----------------------
        public static OwnerGetResponseDto MapGetResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new OwnerGetResponseDto
            {
                OwnerId = reader.GetValue<int>("OwnerId"),
                FullName = reader.GetValue<string>("FullName"),
                PhoneNumber = reader.GetValue<string>("PhoneNumber"),
                Address = reader.GetValue<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        // ---------------------- List Owner Mapper ----------------------
        public static OwnerModel MapOwnerFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new OwnerModel
            {
                OwnerId = reader.GetValue<int>("OwnerId"),
                FullName = reader.GetValue<string>("FullName"),
                PhoneNumber = reader.GetValue<string>("PhoneNumber"),
                Address = reader.GetValue<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }
    }
}