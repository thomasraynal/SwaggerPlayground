
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

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


public class HttpResponseGetPetById400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseGetPetById400Exception()
        : base() { }

    public HttpResponseGetPetById400Exception(string message)
        : base(message) { }

    public HttpResponseGetPetById400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class HttpResponseGetPetById404Exception : Exception, IHasHttpServiceError
{
    public HttpResponseGetPetById404Exception()
        : base() { }

    public HttpResponseGetPetById404Exception(string message)
        : base(message) { }

    public HttpResponseGetPetById404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;

    public string Details => Message;
}


    public abstract class GetPetByIdRequestValidatorBase : AbstractValidator<GetPetByIdRequest>
    {
        public GetPetByIdRequestValidatorBase()
        {
                    RuleFor(request => request.PetId).NotNull().WithMessage("PetId is required");
        }
    }

}

