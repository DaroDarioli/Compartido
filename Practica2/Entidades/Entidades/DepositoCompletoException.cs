using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    public class DepositoCompletoException : Exception
    {
        public DepositoCompletoException()
        {
        }

        public DepositoCompletoException(string message) : base(message)
        {
        }

        public DepositoCompletoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DepositoCompletoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}