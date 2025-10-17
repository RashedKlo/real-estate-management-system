using RealEstateManagement.Data.DTOs.Properties.Create;
using RealEstateManagement.Data.DTOs.Properties.Update;
using RealEstateManagement.Data.DTOs.Properties.Delete;
using RealEstateManagement.Data.DTOs.Properties.Queries;
using RealEstateManagement.Data.Results;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace RealEstateManagement.Services.Properties
{
    public static class PropertiesValidation
    {
        // Valid status values
        private static readonly string[] ValidStatuses = { "جيد", "سيئ", "جيد جدًا", "ممتاز" };

        private const string SyrianPhonePattern = @"^(09\d{8}|\+9639\d{8})$";

        // Valid availability values
        private static readonly string[] ValidAvailabilities = { "متاح", "رهن", "بيع", "إيجار", "غير متاح" };

        // -------------------------------
        //  Private Validation Methods
        // -------------------------------

        private static OperationResult<bool> ValidateLocation(string location)
        {
         
            if (string.IsNullOrWhiteSpace(location))
                return OperationResult<bool>.Failure("الموقع مطلوب ولا يمكن أن يكون فارغاً.");

            if (location.Trim().Length > 250)
                return OperationResult<bool>.Failure("الموقع لا يمكن أن يتجاوز 250 حرفاً.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateNumOfRooms(int numOfRooms)
        {
            if (numOfRooms <= 0)
                return OperationResult<bool>.Failure("عدد الغرف يجب أن يكون أكبر من صفر.");

            if (numOfRooms > 100)
                return OperationResult<bool>.Failure("عدد الغرف لا يمكن أن يتجاوز 100 غرفة.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateStatus(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
                return OperationResult<bool>.Failure("حالة العقار مطلوبة ولا يمكن أن تكون فارغة.");

            if (!ValidStatuses.Contains(status))
                return OperationResult<bool>.Failure("حالة العقار يجب أن تكون: جيد، سيئ، جيد جدًا، أو ممتاز.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateAvailability(string availability)
        {
            if (string.IsNullOrWhiteSpace(availability))
                return OperationResult<bool>.Failure("حالة التوفر مطلوبة ولا يمكن أن تكون فارغة.");

            if (!ValidAvailabilities.Contains(availability))
                return OperationResult<bool>.Failure("حالة التوفر يجب أن تكون: متاح، رهن، بيع، إيجار، أو غير متاح.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidatePrice(decimal price)
        {
            if (price < 0)
                return OperationResult<bool>.Failure("السعر يجب أن يكون أكبر من أو يساوي صفر.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateArea(decimal area)
        {
            if (area <= 0)
                return OperationResult<bool>.Failure("المساحة يجب أن تكون أكبر من صفر.");

            if (area > 10000)
                return OperationResult<bool>.Failure("المساحة تتجاوز الحد المسموح به.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateDescription(string description)
        {
            if (description != null && description.Trim().Length > 500)
                return OperationResult<bool>.Failure("الوصف لا يمكن أن يتجاوز 500 حرف.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidatePropertyId(int propertyId)
        {
            if (propertyId <= 0)
                return OperationResult<bool>.Failure("معرّف العقار غير صالح.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateOwnerId(int? ownerId)
        {
            if (ownerId.HasValue && ownerId.Value <= 0)
                return OperationResult<bool>.Failure("معرّف المالك غير صالح.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateOwnerFullName(string ownerFullName)
        {
            if (string.IsNullOrWhiteSpace(ownerFullName))
                return OperationResult<bool>.Failure("اسم المالك مطلوب عند عدم تحديد معرف المالك.");

            if (ownerFullName.Trim().Length > 100)
                return OperationResult<bool>.Failure("اسم المالك لا يمكن أن يتجاوز 100 حرف.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateOwnerPhoneNumber(string ownerPhoneNumber)
        {
            if (string.IsNullOrWhiteSpace(ownerPhoneNumber))
                return OperationResult<bool>.Failure("رقم هاتف المالك مطلوب عند عدم تحديد معرف المالك.");

            if (ownerPhoneNumber.Trim().Length > 20)
                return OperationResult<bool>.Failure("رقم هاتف المالك لا يمكن أن يتجاوز 20 حرف.");

            if (!Regex.IsMatch(ownerPhoneNumber, SyrianPhonePattern))
                return OperationResult<bool>.Failure("رقم الهاتف غير صالح. يجب أن يكون بالشكل 09XXXXXXXX أو +9639XXXXXXXX.");
            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidatePagination(int page, int limit)
        {
            if (page <= 0)
                return OperationResult<bool>.Failure("رقم الصفحة يجب أن يكون أكبر من الصفر.");

            if (limit <= 0)
                return OperationResult<bool>.Failure("عدد السجلات في الصفحة يجب أن يكون أكبر من الصفر.");

            if (limit > 100)
                return OperationResult<bool>.Failure("لا يمكن عرض أكثر من 100 سجل في الصفحة الواحدة.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidatePriceRange(decimal? priceFrom, decimal? priceTo)
        {
            if (priceFrom.HasValue && priceFrom.Value < 0)
                return OperationResult<bool>.Failure("السعر الأدنى يجب أن يكون أكبر من أو يساوي صفر.");

            if (priceTo.HasValue && priceTo.Value < 0)
                return OperationResult<bool>.Failure("السعر الأعلى يجب أن يكون أكبر من أو يساوي صفر.");

            if (priceFrom.HasValue && priceTo.HasValue && priceFrom.Value > priceTo.Value)
                return OperationResult<bool>.Failure("السعر الأدنى يجب أن يكون أقل من أو يساوي السعر الأعلى.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateAreaRange(decimal? areaFrom, decimal? areaTo)
        {
            if (areaFrom.HasValue && areaFrom.Value < 0)
                return OperationResult<bool>.Failure("المساحة الأدنى يجب أن تكون أكبر من أو تساوي صفر.");

            if (areaTo.HasValue && areaTo.Value < 0)
                return OperationResult<bool>.Failure("المساحة الأعلى يجب أن تكون أكبر من أو تساوي صفر.");

            if (areaFrom.HasValue && areaTo.HasValue && areaFrom.Value > areaTo.Value)
                return OperationResult<bool>.Failure("المساحة الأدنى يجب أن تكون أقل من أو تساوي المساحة الأعلى.");

            return OperationResult<bool>.Success(true);
        }

        // -------------------------------
        //  Public Validation Methods
        // -------------------------------

        public static OperationResult<bool> ValidatePropertyCreation(PropertyCreateRequestDto dto, ILogger logger)
        {
            // Validate required property fields
            var locationCheck = ValidateLocation(dto.Location);
            if (!locationCheck.IsSuccess) return locationCheck;

            var numOfRoomsCheck = ValidateNumOfRooms(dto.NumOfRooms);
            if (!numOfRoomsCheck.IsSuccess) return numOfRoomsCheck;

            var statusCheck = ValidateStatus(dto.Status);
            if (!statusCheck.IsSuccess) return statusCheck;

            var availabilityCheck = ValidateAvailability(dto.Availability);
            if (!availabilityCheck.IsSuccess) return availabilityCheck;

            var priceCheck = ValidatePrice(dto.Price);
            if (!priceCheck.IsSuccess) return priceCheck;

            var areaCheck = ValidateArea(dto.Area);
            if (!areaCheck.IsSuccess) return areaCheck;

            var descriptionCheck = ValidateDescription(dto.Description);
            if (!descriptionCheck.IsSuccess) return descriptionCheck;

            // Validate owner information
            var ownerIdCheck = ValidateOwnerId(dto.OwnerId);
            if (!ownerIdCheck.IsSuccess) return ownerIdCheck;

            // If OwnerId is not provided, owner details must be provided
            if (!dto.OwnerId.HasValue)
            {
                var ownerNameCheck = ValidateOwnerFullName(dto.OwnerFullName);
                if (!ownerNameCheck.IsSuccess) return ownerNameCheck;

                var ownerPhoneCheck = ValidateOwnerPhoneNumber(dto.OwnerPhoneNumber);
                if (!ownerPhoneCheck.IsSuccess) return ownerPhoneCheck;
            }

            logger.LogDebug("تم التحقق من بيانات إنشاء العقار بنجاح: {Location}", dto.Location);
            return OperationResult<bool>.Success(true, "تم التحقق من البيانات بنجاح.");
        }

        public static OperationResult<bool> ValidatePropertyUpdate(PropertyUpdateRequestDto dto, ILogger logger)
        {
            var idCheck = ValidatePropertyId(dto.PropertyId);
            if (!idCheck.IsSuccess) return idCheck;

            // Validate only provided fields (nullable fields can be skipped)
            if (!string.IsNullOrWhiteSpace(dto.Location))
            {
                var locationCheck = ValidateLocation(dto.Location);
                if (!locationCheck.IsSuccess) return locationCheck;
            }

            if (dto.NumOfRooms.HasValue)
            {
                var numOfRoomsCheck = ValidateNumOfRooms(dto.NumOfRooms.Value);
                if (!numOfRoomsCheck.IsSuccess) return numOfRoomsCheck;
            }

            if (!string.IsNullOrWhiteSpace(dto.Status))
            {
                var statusCheck = ValidateStatus(dto.Status);
                if (!statusCheck.IsSuccess) return statusCheck;
            }

            if (!string.IsNullOrWhiteSpace(dto.Availability))
            {
                var availabilityCheck = ValidateAvailability(dto.Availability);
                if (!availabilityCheck.IsSuccess) return availabilityCheck;
            }

            if (dto.Price.HasValue)
            {
                var priceCheck = ValidatePrice(dto.Price.Value);
                if (!priceCheck.IsSuccess) return priceCheck;
            }

            if (dto.Area.HasValue)
            {
                var areaCheck = ValidateArea(dto.Area.Value);
                if (!areaCheck.IsSuccess) return areaCheck;
            }

            var descriptionCheck = ValidateDescription(dto.Description);
            if (!descriptionCheck.IsSuccess) return descriptionCheck;

            logger.LogDebug("تم التحقق من بيانات تحديث العقار بنجاح: {PropertyId}", dto.PropertyId);
            return OperationResult<bool>.Success(true, "تم التحقق من البيانات بنجاح.");
        }

        public static OperationResult<bool> ValidatePropertyDeletion(PropertyDeleteRequestDto dto, ILogger logger)
        {
            var idCheck = ValidatePropertyId(dto.PropertyId);
            if (!idCheck.IsSuccess) return idCheck;

            logger.LogDebug("تم التحقق من بيانات حذف العقار بنجاح: {PropertyId}", dto.PropertyId);
            return OperationResult<bool>.Success(true, "تم التحقق من البيانات بنجاح.");
        }

        public static OperationResult<bool> ValidateGetProperty(PropertyGetRequestDto dto, ILogger logger)
        {
            var idCheck = ValidatePropertyId(dto.PropertyId);
            if (!idCheck.IsSuccess) return idCheck;

            logger.LogDebug("تم التحقق من طلب جلب العقار بنجاح: {PropertyId}", dto.PropertyId);
            return OperationResult<bool>.Success(true, "تم التحقق من البيانات بنجاح.");
        }

        public static OperationResult<bool> ValidateGetProperties(PropertiesGetRequestDto dto, ILogger logger)
        {
            var paginationCheck = ValidatePagination(dto.Page, dto.Limit);
            if (!paginationCheck.IsSuccess) return paginationCheck;

            // Validate filter fields if provided
            if (!string.IsNullOrWhiteSpace(dto.Location) && dto.Location.Trim().Length > 250)
                return OperationResult<bool>.Failure("الموقع في الفلتر لا يمكن أن يتجاوز 250 حرفاً.");

            if (dto.NumOfRooms.HasValue)
            {
                var numOfRoomsCheck = ValidateNumOfRooms(dto.NumOfRooms.Value);
                if (!numOfRoomsCheck.IsSuccess) return numOfRoomsCheck;
            }

            if (!string.IsNullOrWhiteSpace(dto.Status))
            {
                var statusCheck = ValidateStatus(dto.Status);
                if (!statusCheck.IsSuccess) return statusCheck;
            }

            if (!string.IsNullOrWhiteSpace(dto.Availability))
            {
                var availabilityCheck = ValidateAvailability(dto.Availability);
                if (!availabilityCheck.IsSuccess) return availabilityCheck;
            }

            var priceRangeCheck = ValidatePriceRange(dto.PriceFrom, dto.PriceTo);
            if (!priceRangeCheck.IsSuccess) return priceRangeCheck;

            var areaRangeCheck = ValidateAreaRange(dto.AreaFrom, dto.AreaTo);
            if (!areaRangeCheck.IsSuccess) return areaRangeCheck;

            logger.LogDebug("تم التحقق من طلب جلب العقارات بنجاح: Page={Page}, Limit={Limit}", dto.Page, dto.Limit);
            return OperationResult<bool>.Success(true, "تم التحقق من البيانات بنجاح.");
        }
    }
}