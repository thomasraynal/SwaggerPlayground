
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class FindPetsByStatusRequest
    {
      public IEnumerable< string > Status {get; set; }

      public override bool Equals(object obj)
        {
            return obj is FindPetsByStatusRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(FindPetsByStatusRequest).GetHashCode();
                if(default != Status) hashCode = (hashCode * 397) ^ Status.GetHashCode();
                return hashCode;
            }
        }


    }


public class FindPetsByStatus400Exception : Exception, IHasHttpServiceError
{
    public FindPetsByStatus400Exception()
        : base() { }

    public FindPetsByStatus400Exception(string message)
        : base(message) { }

    public FindPetsByStatus400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public class FindPetsByStatusRequestValidator : AbstractValidator<FindPetsByStatusRequest>
    {
        public FindPetsByStatusRequestValidator()
        {
        }
    }

}

