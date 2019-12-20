
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace ImperiumApp.Imperium
{
    public partial class GetActiveCardsRequest
    {
      public string CRACKER_API_KEY {get; set; }

      public override bool Equals(object obj)
        {
            return obj is GetActiveCardsRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetActiveCardsRequest).GetHashCode();
                if(default != CRACKER_API_KEY) hashCode = (hashCode * 397) ^ CRACKER_API_KEY.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseGetActiveCards401Exception : Exception, IHasHttpServiceError
{
    public HttpResponseGetActiveCards401Exception()
        : base() { }

    public HttpResponseGetActiveCards401Exception(string message)
        : base(message) { }

    public HttpResponseGetActiveCards401Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)401;

    public string Details => Message;
}


    public abstract class GetActiveCardsRequestValidatorBase : AbstractValidator<GetActiveCardsRequest>
    {
    public GetActiveCardsRequestValidatorBase()
    {
    RuleFor(request => request.CRACKER_API_KEY).NotNull().NotEmpty().WithMessage("CRACKER_API_KEY is required");
    }
    }

    }

