using System;

namespace RaidManager.Domain.Exceptions
{
    /// <summary>
    /// Exception base for technical errors.
    /// </summary>
    public class TechnicalException : Exception
    {
        public TechnicalException(string message) : base(message)
        {
        }
        public TechnicalException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}