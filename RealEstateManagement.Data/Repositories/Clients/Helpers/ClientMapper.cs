using System;
using System.Data.SqlClient;
using RealEstateManagement.Data.DTOs.Clients.Create;
using RealEstateManagement.Data.DTOs.Clients.Update;
using RealEstateManagement.Data.DTOs.Clients.Delete;
using RealEstateManagement.Data.DTOs.Clients.Queries;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Models;

namespace RealEstateManagement.Data.Repositories.Client.Helpers
{
    public static class ClientMapper
    {
        public static ClientPropertyModel MapClientPropertyFromReader(SqlDataReader reader)
        {
            return new ClientPropertyModel
            {
                ClientPropertyId = reader.GetValueOrDefault<int>("ClientPropertyId"),
                ClientId = reader.GetValueOrDefault<int>("ClientId"),
                PropertyId = reader.GetValueOrDefault<int>("PropertyId"),
                TransactionType = reader.GetValueOrDefault<string>("TransactionType"),
                TransactionDate = reader.GetValueOrDefault<DateTime>("TransactionDate"),
                Amount = reader.GetValueOrDefault<decimal>("Amount"),
                ClientFullName = reader.GetValueOrDefault<string>("ClientFullName"),
                ClientPhoneNumber = reader.GetValueOrDefault<string>("ClientPhoneNumber"),
                ClientAddress = reader.GetValueOrDefault<string>("ClientAddress"),
                PropertyLocation = reader.GetValueOrDefault<string>("PropertyLocation"),
                NumOfRooms = reader.GetValueOrDefault<int>("NumOfRooms"),
                PropertyStatus = reader.GetValueOrDefault<string>("PropertyStatus"),
                PropertyAvailability = reader.GetValueOrDefault<string>("PropertyAvailability"),
                RentPrice = reader.GetValueOrDefault<decimal?>("RentPrice"),
                SalePrice = reader.GetValueOrDefault<decimal?>("SalePrice"),
                MortgagePrice = reader.GetValueOrDefault<decimal?>("MortgagePrice"),
                OwnerId = reader.GetValueOrDefault<int>("OwnerId"),
                OwnerFullName = reader.GetValueOrDefault<string>("OwnerFullName"),
                OwnerPhoneNumber = reader.GetValueOrDefault<string>("OwnerPhoneNumber"),
                OwnerAddress = reader.GetValueOrDefault<string>("OwnerAddress")
            };
        }

        public static ClientCreateResponseDto MapCreateResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new ClientCreateResponseDto
            {
                ClientId = reader.GetValue<int>("ClientId"),
                FullName = reader.GetValue<string>("FullName"),
                PhoneNumber = reader.GetValue<string>("PhoneNumber"),
                Address = reader.GetValue<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        public static ClientUpdateResponseDto MapUpdateResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new ClientUpdateResponseDto
            {
                ClientId = reader.GetValue<int>("ClientId"),
                FullName = reader.GetValueOrDefault<string>("FullName"),
                PhoneNumber = reader.GetValueOrDefault<string>("PhoneNumber"),
                Address = reader.GetValueOrDefault<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        public static ClientDeleteResponseDto MapDeleteResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new ClientDeleteResponseDto
            {
                ClientId = reader.GetValue<int>("ClientId"),
                FullName = reader.GetValue<string>("FullName"),
                PhoneNumber = reader.GetValue<string>("PhoneNumber"),
                Address = reader.GetValue<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        public static ClientGetResponseDto MapGetResponseFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new ClientGetResponseDto
            {
                ClientId = reader.GetValue<int>("ClientId"),
                FullName = reader.GetValue<string>("FullName"),
                PhoneNumber = reader.GetValue<string>("PhoneNumber"),
                Address = reader.GetValue<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }

        public static ClientModel MapClientFromReader(SqlDataReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            return new ClientModel
            {
                ClientId = reader.GetValue<int>("ClientId"),
                FullName = reader.GetValue<string>("FullName"),
                PhoneNumber = reader.GetValue<string>("PhoneNumber"),
                Address = reader.GetValue<string>("Address"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt")
            };
        }
    }
}
