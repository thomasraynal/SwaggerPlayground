
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class UpdateUserRequest
    {
      public string Username {get; set; }
      public User Body {get; set; }

      public override bool Equals(object obj)
        {
            return obj is UpdateUserRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(UpdateUserRequest).GetHashCode();
                if(default != Username) hashCode = (hashCode * 397) ^ Username.GetHashCode();
                if(default != Body) hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseUpdateUser400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseUpdateUser400Exception()
        : base() { }

    public HttpResponseUpdateUser400Exception(string message)
        : base(message) { }

    public HttpResponseUpdateUser400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class HttpResponseUpdateUser404Exception : Exception, IHasHttpServiceError
{
    public HttpResponseUpdateUser404Exception()
        : base() { }

    public HttpResponseUpdateUser404Exception(string message)
        : base(message) { }

    public HttpResponseUpdateUser404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;

    public string Details => Message;
}


    public abstract class UpdateUserRequestValidatorBase : AbstractValidator<UpdateUserRequest>
    {
    public UpdateUserRequestValidatorBase()
    {
    RuleFor(request => request.Username).NotNull().NotEmpty().WithMessage("Username is required");
    }
    }

    }

