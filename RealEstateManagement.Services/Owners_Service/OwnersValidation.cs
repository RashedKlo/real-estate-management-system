using RealEstateManagement.Data.DTOs.Owners.Create;
using RealEstateManagement.Data.DTOs.Owners.Update;
using RealEstateManagement.Data.DTOs.Owners.Delete;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Results;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace RealEstateManagement.Services.Owner
{
    public static class OwnersValidation
    {
        private const string SyrianPhonePattern = @"^(09\d{8}|\+9639\d{8})$";

        private static OperationResult<bool> ValidateFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return OperationResult<bool>.Failure("الاسم الكامل مطلوب ولا يمكن أن يكون فارغاً.");

            if (fullName.Trim().Length > 150)
                return OperationResult<bool>.Failure("الاسم الكامل لا يمكن أن يتجاوز 150 حرفاً.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return OperationResult<bool>.Failure("رقم الهاتف مطلوب ولا يمكن أن يكون فارغاً.");

            var trimmed = phoneNumber.Trim();

            if (trimmed.Length > 20)
                return OperationResult<bool>.Failure("رقم الهاتف لا يمكن أن يتجاوز 20 حرفاً.");

            if (!Regex.IsMatch(trimmed, SyrianPhonePattern))
                return OperationResult<bool>.Failure("رقم الهاتف غير صالح. يجب أن يكون بالشكل 09XXXXXXXX أو +9639XXXXXXXX.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                return OperationResult<bool>.Failure("العنوان مطلوب ولا يمكن أن يكون فارغاً.");

            if (address.Trim().Length > 250)
                return OperationResult<bool>.Failure("العنوان لا يمكن أن يتجاوز 250 حرفاً.");

            return OperationResult<bool>.Success(true);
        }

        private static OperationResult<bool> ValidateOwnerId(int ownerId)
        {
            if (ownerId <= 0)
                return OperationResult<bool>.Failure("معرّف المالك غير صالح.");

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

        // -------------------------------
        //  validation methods
        // -------------------------------

        public static OperationResult<bool> ValidateOwnerCreation(OwnerCreateRequestDto dto, ILogger logger)
        {
            var fullNameCheck = ValidateFullName(dto.FullName);
            if (!fullNameCheck.IsSuccess) return fullNameCheck;

            var phoneCheck = ValidatePhoneNumber(dto.PhoneNumber);
            if (!phoneCheck.IsSuccess) return phoneCheck;

            var addressCheck = ValidateAddress(dto.Address);
            if (!addressCheck.IsSuccess) return addressCheck;

            logger.LogDebug("تم التحقق من بيانات إنشاء المالك بنجاح: {FullName}, {PhoneNumber}", dto.FullName, dto.PhoneNumber);
            return OperationResult<bool>.Success(true, "تم التحقق من البيانات بنجاح.");
        }

        public static OperationResult<bool> ValidateGetOwnerProperties(OwnerPropertiesGetRequestDto dto, ILogger logger)
        {
            if (dto.OwnerId <= 0)
            {
                logger.LogWarning("Invalid OwnerId: {OwnerId}", dto.OwnerId);
                return OperationResult<bool>.Failure("Owner ID must be positive");
            }

            if (dto.Page <= 0)
            {
                logger.LogWarning("Invalid Page: {Page}", dto.Page);
                return OperationResult<bool>.Failure("Page must be positive");
            }

            if (dto.Limit <= 0)
            {
                logger.LogWarning("Invalid Limit: {Limit}", dto.Limit);
                return OperationResult<bool>.Failure("Limit must be positive");
            }

            if (dto.Limit > 100)
            {
                logger.LogWarning("Limit too large: {Limit}", dto.Limit);
                return OperationResult<bool>.Failure("Limit cannot exceed 100");
            }

            return OperationResult<bool>.Success(true);
        }

        public static OperationResult<bool> ValidateOwnerUpdate(OwnerUpdateRequestDto dto, ILogger logger)
        {
            var idCheck = ValidateOwnerId(dto.OwnerId);
            if (!idCheck.IsSuccess) return idCheck;

            var fullNameCheck = ValidateFullName(dto.FullName);
            if (!fullNameCheck.IsSuccess) return fullNameCheck;

            var phoneCheck = ValidatePhoneNumber(dto.PhoneNumber);
            if (!phoneCheck.IsSuccess) return phoneCheck;

            var addressCheck = ValidateAddress(dto.Address);
            if (!addressCheck.IsSuccess) return addressCheck;

            logger.LogDebug("تم التحقق من بيانات تحديث المالك بنجاح: {OwnerId}", dto.OwnerId);
            return OperationResult<bool>.Success(true, "تم التحقق من البيانات بنجاح.");
        }

        public static OperationResult<bool> ValidateOwnerDeletion(OwnerDeleteRequestDto dto, ILogger logger)
        {
            var idCheck = ValidateOwnerId(dto.OwnerId);
            if (!idCheck.IsSuccess) return idCheck;

            logger.LogDebug("تم التحقق من بيانات حذف المالك بنجاح: {OwnerId}", dto.OwnerId);
            return OperationResult<bool>.Success(true, "تم التحقق من البيانات بنجاح.");
        }

        public static OperationResult<bool> ValidateGetOwners(OwnersGetRequestDto dto, ILogger logger)
        {
            var paginationCheck = ValidatePagination(dto.Page, dto.Limit);
            if (!paginationCheck.IsSuccess) return paginationCheck;

            logger.LogDebug("تم التحقق من طلب جلب الملاك بنجاح: Page={Page}, Limit={Limit}", dto.Page, dto.Limit);
            return OperationResult<bool>.Success(true, "تم التحقق من البيانات بنجاح.");
        }
    }
}