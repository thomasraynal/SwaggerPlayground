
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class FindPetsByTagsRequest
    {
      public IEnumerable< string > Tags {get; set; }

      public override bool Equals(object obj)
        {
            return obj is FindPetsByTagsRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(FindPetsByTagsRequest).GetHashCode();
                if(default != Tags) hashCode = (hashCode * 397) ^ Tags.GetHashCode();
                return hashCode;
            }
        }


    }


public class FindPetsByTags400Exception : Exception, IHasHttpServiceError
{
    public FindPetsByTags400Exception()
        : base() { }

    public FindPetsByTags400Exception(string message)
        : base(message) { }

    public FindPetsByTags400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;
}



}


