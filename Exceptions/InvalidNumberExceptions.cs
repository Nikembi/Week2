using System;

namespace Week2.Exceptions
{
    internal class InvalidPhoneNumberException : Exception
    {
        // Default constructor
        public InvalidPhoneNumberException()
            : base("Invalid phone number.")
        {
        }

        // Constructor that accepts a custom message
        public InvalidPhoneNumberException(string message)
            : base(message)
        {
        }

        // Constructor that accepts a custom message and an inner exception
        public InvalidPhoneNumberException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
}
