
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace PetStoreApp.PetStore
{
    public partial class PlaceOrderRequest
    {
      public Order Body {get; set; }

      public override bool Equals(object obj)
        {
            return obj is PlaceOrderRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(PlaceOrderRequest).GetHashCode();
                if(default != Body) hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponsePlaceOrder400Exception : Exception, IHasHttpServiceError
{
    public HttpResponsePlaceOrder400Exception()
        : base() { }

    public HttpResponsePlaceOrder400Exception(string message)
        : base(message) { }

    public HttpResponsePlaceOrder400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public abstract class PlaceOrderRequestValidatorBase : AbstractValidator<PlaceOrderRequest>
    {
    public PlaceOrderRequestValidatorBase()
    {
    }
    }

    }

