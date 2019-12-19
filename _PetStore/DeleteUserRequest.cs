
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class DeleteUserRequest
    {
      public string Username {get; set; }

      public override bool Equals(object obj)
        {
            return obj is DeleteUserRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(DeleteUserRequest).GetHashCode();
                if(default != Username) hashCode = (hashCode * 397) ^ Username.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseDeleteUser400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseDeleteUser400Exception()
        : base() { }

    public HttpResponseDeleteUser400Exception(string message)
        : base(message) { }

    public HttpResponseDeleteUser400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class HttpResponseDeleteUser404Exception : Exception, IHasHttpServiceError
{
    public HttpResponseDeleteUser404Exception()
        : base() { }

    public HttpResponseDeleteUser404Exception(string message)
        : base(message) { }

    public HttpResponseDeleteUser404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;

    public string Details => Message;
}


    public abstract class DeleteUserRequestValidatorBase : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserRequestValidatorBase()
        {
                    RuleFor(request => request.Username).NotNull().NotEmpty().WithMessage("Username is required");
        }
    }

}
