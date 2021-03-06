
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace PetStoreApp.PetStore
{
    public partial class LoginUserRequest
    {
      public string Username {get; set; }
      public string Password {get; set; }

      public override bool Equals(object obj)
        {
            return obj is LoginUserRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(LoginUserRequest).GetHashCode();
                if(default != Username) hashCode = (hashCode * 397) ^ Username.GetHashCode();
                if(default != Password) hashCode = (hashCode * 397) ^ Password.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseLoginUser400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseLoginUser400Exception()
        : base() { }

    public HttpResponseLoginUser400Exception(string message)
        : base(message) { }

    public HttpResponseLoginUser400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public class LoginUserRequestValidator : AbstractValidator<LoginUserRequest>
    {
    public LoginUserRequestValidator()
    {
    }
    }

    }

