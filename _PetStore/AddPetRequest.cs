
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class AddPetRequest
    {
      public Pet Body {get; set; }

      public override bool Equals(object obj)
        {
            return obj is AddPetRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(AddPetRequest).GetHashCode();
                if(default != Body) hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }


public class AddPet400Exception : Exception, IHasHttpServiceError
{
    public AddPet400Exception()
        : base() { }

    public AddPet400Exception(string message)
        : base(message) { }

    public AddPet400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;
}



}


