
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class DeleteOrderRequest
    {
      public string OrderId {get; set; }

      public override bool Equals(object obj)
        {
            return obj is DeleteOrderRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(DeleteOrderRequest).GetHashCode();
                if(default != OrderId) hashCode = (hashCode * 397) ^ OrderId.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseDeleteOrder400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseDeleteOrder400Exception()
        : base() { }

    public HttpResponseDeleteOrder400Exception(string message)
        : base(message) { }

    public HttpResponseDeleteOrder400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class HttpResponseDeleteOrder404Exception : Exception, IHasHttpServiceError
{
    public HttpResponseDeleteOrder404Exception()
        : base() { }

    public HttpResponseDeleteOrder404Exception(string message)
        : base(message) { }

    public HttpResponseDeleteOrder404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;

    public string Details => Message;
}


    public abstract class DeleteOrderRequestValidatorBase : AbstractValidator<DeleteOrderRequest>
    {
        public DeleteOrderRequestValidatorBase()
        {
                    RuleFor(request => request.OrderId).NotNull().NotEmpty().WithMessage("OrderId is required");
        }
    }

}

