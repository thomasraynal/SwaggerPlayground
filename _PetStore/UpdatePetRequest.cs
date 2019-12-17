
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class UpdatePetRequest
    {
      public Pet Body {get; set; }

      public override bool Equals(object obj)
        {
            return obj is UpdatePetRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(UpdatePetRequest).GetHashCode();
                if(default != Body) hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }


public class UpdatePet400Exception : Exception, IHasHttpServiceError
{
    public UpdatePet400Exception()
        : base() { }

    public UpdatePet400Exception(string message)
        : base(message) { }

    public UpdatePet400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class UpdatePet404Exception : Exception, IHasHttpServiceError
{
    public UpdatePet404Exception()
        : base() { }

    public UpdatePet404Exception(string message)
        : base(message) { }

    public UpdatePet404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;

    public string Details => Message;
}

public class UpdatePet405Exception : Exception, IHasHttpServiceError
{
    public UpdatePet405Exception()
        : base() { }

    public UpdatePet405Exception(string message)
        : base(message) { }

    public UpdatePet405Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)405;

    public string Details => Message;
}


    public class UpdatePetRequestValidator : AbstractValidator<UpdatePetRequest>
    {
        public UpdatePetRequestValidator()
        {
        }
    }

}

