using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FluentEntity_ConsoleApp.FluentExceptions
{
    public class FluentException : Exception
    {
        public FluentException() : base("FluentEntity Exception")
        {
        }

        public FluentException(string message) : base(message)
        {
        }

        public FluentException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
