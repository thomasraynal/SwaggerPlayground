
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace PetStoreApp.PetStore
{
    public partial class GetUserByNameRequest
    {
      public string Username {get; set; }

      public override bool Equals(object obj)
        {
            return obj is GetUserByNameRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetUserByNameRequest).GetHashCode();
                if(default != Username) hashCode = (hashCode * 397) ^ Username.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseGetUserByName400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseGetUserByName400Exception()
        : base() { }

    public HttpResponseGetUserByName400Exception(string message)
        : base(message) { }

    public HttpResponseGetUserByName400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class HttpResponseGetUserByName404Exception : Exception, IHasHttpServiceError
{
    public HttpResponseGetUserByName404Exception()
        : base() { }

    public HttpResponseGetUserByName404Exception(string message)
        : base(message) { }

    public HttpResponseGetUserByName404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;

    public string Details => Message;
}


    public class GetUserByNameRequestValidator : AbstractValidator<GetUserByNameRequest>
    {
    public GetUserByNameRequestValidator()
    {
    RuleFor(request => request.Username).NotNull().NotEmpty().WithMessage("Username is required");
    }
    }

    }

