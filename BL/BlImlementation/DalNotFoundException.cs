using System.Runtime.Serialization;

namespace DO
{
    [Serializable]
    internal class DalNotFoundException : Exception
    {
        public DalNotFoundException()
        {
        }

        public DalNotFoundException(string? message) : base(message)
        {
        }

        public DalNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DalNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}