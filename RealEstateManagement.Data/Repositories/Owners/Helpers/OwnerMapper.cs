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

        public static OwnerUpdateResponseDto MapUpdateResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new OwnerUpdateResponseDto
            {
                OwnerId = reader.GetValue<int>("OwnerId"),
                FullName = reader.GetValue<string>("FullName"),
                PhoneNumber = reader.GetValue<string>("PhoneNumber"),
                Address = reader.GetValue<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

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
