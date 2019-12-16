
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class DeleteOrderRequest
    {
      public string OrderId {get; set; }

      public override bool Equals(object obj)
        {
            return obj is DeleteOrderRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(DeleteOrderRequest).GetHashCode();
                if(default != OrderId) hashCode = (hashCode * 397) ^ OrderId.GetHashCode();
                return hashCode;
            }
        }


    }


public class DeleteOrder400Exception : Exception, IHasHttpServiceError
{
    public DeleteOrder400Exception()
        : base() { }

    public DeleteOrder400Exception(string message)
        : base(message) { }

    public DeleteOrder400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;
}

public class DeleteOrder404Exception : Exception, IHasHttpServiceError
{
    public DeleteOrder404Exception()
        : base() { }

    public DeleteOrder404Exception(string message)
        : base(message) { }

    public DeleteOrder404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;
}



}


