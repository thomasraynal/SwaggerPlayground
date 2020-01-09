
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace ResourceServiceApp.ResourceServiceGateway
{
    public partial class StoreResourceItemsRequest
    {
      public IEnumerable< object > Body {get; set; }

      public override bool Equals(object obj)
        {
            return obj is StoreResourceItemsRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(StoreResourceItemsRequest).GetHashCode();
                if(default != Body) hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseStoreResourceItems400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseStoreResourceItems400Exception()
        : base() { }

    public HttpResponseStoreResourceItems400Exception(string message)
        : base(message) { }

    public HttpResponseStoreResourceItems400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public class StoreResourceItemsRequestValidator : AbstractValidator<StoreResourceItemsRequest>
    {
    public StoreResourceItemsRequestValidator()
    {
    RuleFor(request => request.Body).NotNull().WithMessage("Body is required");
    }
    }

    }

