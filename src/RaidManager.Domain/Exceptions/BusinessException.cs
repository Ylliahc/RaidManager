using System;

namespace RaidManager.Domain.Exceptions
{
    /// <summary>
    /// Exception base for business errors.
    /// </summary>
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {
        }

        public BusinessException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}