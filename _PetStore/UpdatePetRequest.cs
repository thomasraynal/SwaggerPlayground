
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


public class HttpResponseUpdatePet400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseUpdatePet400Exception()
        : base() { }

    public HttpResponseUpdatePet400Exception(string message)
        : base(message) { }

    public HttpResponseUpdatePet400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class HttpResponseUpdatePet404Exception : Exception, IHasHttpServiceError
{
    public HttpResponseUpdatePet404Exception()
        : base() { }

    public HttpResponseUpdatePet404Exception(string message)
        : base(message) { }

    public HttpResponseUpdatePet404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;

    public string Details => Message;
}

public class HttpResponseUpdatePet405Exception : Exception, IHasHttpServiceError
{
    public HttpResponseUpdatePet405Exception()
        : base() { }

    public HttpResponseUpdatePet405Exception(string message)
        : base(message) { }

    public HttpResponseUpdatePet405Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)405;

    public string Details => Message;
}


    public abstract class UpdatePetRequestValidatorBase : AbstractValidator<UpdatePetRequest>
    {
        public UpdatePetRequestValidatorBase()
        {
        }
    }

}

