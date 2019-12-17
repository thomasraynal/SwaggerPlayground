
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class GetOrderByIdRequest
    {
      public string OrderId {get; set; }

      public override bool Equals(object obj)
        {
            return obj is GetOrderByIdRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetOrderByIdRequest).GetHashCode();
                if(default != OrderId) hashCode = (hashCode * 397) ^ OrderId.GetHashCode();
                return hashCode;
            }
        }


    }


public class GetOrderById400Exception : Exception, IHasHttpServiceError
{
    public GetOrderById400Exception()
        : base() { }

    public GetOrderById400Exception(string message)
        : base(message) { }

    public GetOrderById400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class GetOrderById404Exception : Exception, IHasHttpServiceError
{
    public GetOrderById404Exception()
        : base() { }

    public GetOrderById404Exception(string message)
        : base(message) { }

    public GetOrderById404Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)404;

    public string Details => Message;
}


    public class GetOrderByIdRequestValidator : AbstractValidator<GetOrderByIdRequest>
    {
        public GetOrderByIdRequestValidator()
        {
                    RuleFor(request => request.OrderId).NotNull().NotEmpty().WithMessage("OrderId is required");
        }
    }

}

