using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    public  class EsCeroException : Exception
    {
        public EsCeroException()
        {
        }

        public EsCeroException(string message) : base(message)
        {
        }

        public EsCeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EsCeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}