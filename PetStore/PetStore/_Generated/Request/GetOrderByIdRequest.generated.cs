
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace PetStoreApp.PetStore
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


public class HttpResponseGetOrderById400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseGetOrderById400Exception()
        : base() { }

    public HttpResponseGetOrderById400Exception(string message)
        : base(message) { }

    public HttpResponseGetOrderById400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}

public class HttpResponseGetOrderById404Exception : Exception, IHasHttpServiceError
{
    public HttpResponseGetOrderById404Exception()
        : base() { }

    public HttpResponseGetOrderById404Exception(string message)
        : base(message) { }

    public HttpResponseGetOrderById404Exception(string message, Exception innerException)
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

