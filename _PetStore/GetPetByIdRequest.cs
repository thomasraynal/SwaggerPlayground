
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class GetPetByIdRequest
    {
      public long PetId {get; set; }

      public override bool Equals(object obj)
        {
            return obj is GetPetByIdRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetPetByIdRequest).GetHashCode();
                if(default != PetId) hashCode = (hashCode * 397) ^ PetId.GetHashCode();
                return hashCode;
            }
        }


    }


public class GetPetById400Exception : Exception, IHasHttpServiceError
{
    public GetPetById400Exception()
        : base() { }

    public GetPetById400Exception(string message)
        : base(message) { }

    public GetPetById400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;
}

public class GetPetById404Exception : Exception, IHasHttpServiceError
{
    public GetPetById404Exception()
        : base() { }

    public GetPetById404Exception(string message)
        : base(message) { }

    public GetPetById404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;
}



}


