using System;
using System.Collections.Generic;
using System.Text;

namespace FluentEntity_ConsoleApp.FluentExceptions
{
    public class ArgumentFluentEntityException : FluentException
    {
        public ArgumentFluentEntityException() : base("Property type cannot be converted to value type")
        {
        }

        public ArgumentFluentEntityException(string message) : base(message)
        {
        }

        public ArgumentFluentEntityException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
