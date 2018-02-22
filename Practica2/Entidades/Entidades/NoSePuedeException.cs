using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    internal class NoSePuedeException : Exception
    {
        public NoSePuedeException()
        {
        }

        public NoSePuedeException(string message) : base(message)
        {
        }

        public NoSePuedeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoSePuedeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}