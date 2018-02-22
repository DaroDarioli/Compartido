using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    internal class YaAsignadaException : Exception
    {
        public YaAsignadaException()
        {
        }

        public YaAsignadaException(string message) : base(message)
        {
        }

        public YaAsignadaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected YaAsignadaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}