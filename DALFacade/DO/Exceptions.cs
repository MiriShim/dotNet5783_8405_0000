using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DO;

public class EntityException : Exception
{
    public int? EntityId { get; set; }
    public object? Entity { get; set; }
    public EntityException()
    {
    }

    public EntityException(string? message) : base(message)
    {
    }

    public EntityException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected EntityException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }


}


[Serializable]
public    class EntityNotFoundException : EntityException
{
     
    public EntityNotFoundException()
    {
    }

    public EntityNotFoundException(string? message) : base(message)
    {
    }

    public EntityNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected EntityNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }


}

public class DuplicateIdException : EntityException
{
     
    public DuplicateIdException()
    {
    }

    public DuplicateIdException(string? message) : base(message)
    {
    }

    public DuplicateIdException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected DuplicateIdException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

