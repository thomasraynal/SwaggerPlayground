
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class GetUserByNameRequest
    {
      public string Username {get; set; }

      public override bool Equals(object obj)
        {
            return obj is GetUserByNameRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetUserByNameRequest).GetHashCode();
                if(default != Username) hashCode = (hashCode * 397) ^ Username.GetHashCode();
                return hashCode;
            }
        }


    }


public class GetUserByName400Exception : Exception, IHasHttpServiceError
{
    public GetUserByName400Exception()
        : base() { }

    public GetUserByName400Exception(string message)
        : base(message) { }

    public GetUserByName400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class GetUserByName404Exception : Exception, IHasHttpServiceError
{
    public GetUserByName404Exception()
        : base() { }

    public GetUserByName404Exception(string message)
        : base(message) { }

    public GetUserByName404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;

    public string Details => Message;
}



}


