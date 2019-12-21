
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace PetStoreApp.PetStore
{
    public partial class DeletePetRequest
    {
      public long PetId {get; set; }

      public override bool Equals(object obj)
        {
            return obj is DeletePetRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(DeletePetRequest).GetHashCode();
                if(default != PetId) hashCode = (hashCode * 397) ^ PetId.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseDeletePet400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseDeletePet400Exception()
        : base() { }

    public HttpResponseDeletePet400Exception(string message)
        : base(message) { }

    public HttpResponseDeletePet400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public class DeletePetRequestValidator : AbstractValidator<DeletePetRequest>
    {
    public DeletePetRequestValidator()
    {
    RuleFor(request => request.PetId).NotNull().WithMessage("PetId is required");
    }
    }

    }

