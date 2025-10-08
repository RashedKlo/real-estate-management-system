using System;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateManagement.Data.Results
{
    /// <summary>
    /// Unified result pattern for all operations across the application
    /// </summary>
    public sealed class OperationResult<T>
    {
        public bool IsSuccess { get; }
        public T Data { get; }
        public string Message { get; }
        public IReadOnlyList<string> Errors { get; }

        private OperationResult(bool isSuccess, T data, string message, IReadOnlyList<string> errors = null)
        {
            IsSuccess = isSuccess;
            Data = data;
            Message = message ?? string.Empty;
            Errors = errors ?? Array.Empty<string>();
        }


        public static OperationResult<T> Success(T data, string message = "Operation completed successfully")
        {
            if (data == null && !typeof(T).IsValueType && Nullable.GetUnderlyingType(typeof(T)) == null)
                throw new ArgumentNullException(nameof(data), "Data cannot be null for successful operation");

            return new OperationResult<T>(true, data, message);
        }


        public static OperationResult<T> Failure(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Failure message cannot be null or empty", nameof(message));

            return new OperationResult<T>(false, default(T), message);
        }

        public static OperationResult<T> Failure(string message, IEnumerable<string> errors)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Failure message cannot be null or empty", nameof(message));

            var errorList = errors.ToArray() ?? Array.Empty<string>();
            return new OperationResult<T>(false, default(T), message, errorList);
        }

    

        public override string ToString()
        {
            var status = IsSuccess ? "Success" : "Failure";
            return $"{status}: {Message}";
        }
    }


}