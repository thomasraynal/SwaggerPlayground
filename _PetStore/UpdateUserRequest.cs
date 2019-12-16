
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class UpdateUserRequest
    {
      public string Username {get; set; }
      public User Body {get; set; }

      public override bool Equals(object obj)
        {
            return obj is UpdateUserRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(UpdateUserRequest).GetHashCode();
                if(default != Username) hashCode = (hashCode * 397) ^ Username.GetHashCode();
                if(default != Body) hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }


public class UpdateUser400Exception : Exception, IHasHttpServiceError
{
    public UpdateUser400Exception()
        : base() { }

    public UpdateUser400Exception(string message)
        : base(message) { }

    public UpdateUser400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;
}

public class UpdateUser404Exception : Exception, IHasHttpServiceError
{
    public UpdateUser404Exception()
        : base() { }

    public UpdateUser404Exception(string message)
        : base(message) { }

    public UpdateUser404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;
}



}


