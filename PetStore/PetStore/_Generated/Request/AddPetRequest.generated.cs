
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace PetStoreApp.PetStore
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


public class HttpResponseAddPet400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseAddPet400Exception()
        : base() { }

    public HttpResponseAddPet400Exception(string message)
        : base(message) { }

    public HttpResponseAddPet400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class HttpResponseAddPet405Exception : Exception, IHasHttpServiceError
{
    public HttpResponseAddPet405Exception()
        : base() { }

    public HttpResponseAddPet405Exception(string message)
        : base(message) { }

    public HttpResponseAddPet405Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)405;

    public string Details => Message;
}


    public abstract class AddPetRequestValidatorBase : AbstractValidator<AddPetRequest>
    {
    public AddPetRequestValidatorBase()
    {
    RuleFor(request => request.Body).NotNull().WithMessage("Body is required");
    }
    }

    }

