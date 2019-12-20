
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.Imperium
{
    public partial class GetCardsRequest
    {
      public string CRACKER_API_KEY {get; set; }
      public string CoachName {get; set; }
      public int History {get; set; }

      public override bool Equals(object obj)
        {
            return obj is GetCardsRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetCardsRequest).GetHashCode();
                if(default != CRACKER_API_KEY) hashCode = (hashCode * 397) ^ CRACKER_API_KEY.GetHashCode();
                if(default != CoachName) hashCode = (hashCode * 397) ^ CoachName.GetHashCode();
                if(default != History) hashCode = (hashCode * 397) ^ History.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseGetCards401Exception : Exception, IHasHttpServiceError
{
    public HttpResponseGetCards401Exception()
        : base() { }

    public HttpResponseGetCards401Exception(string message)
        : base(message) { }

    public HttpResponseGetCards401Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)401;

    public string Details => Message;
}


    public abstract class GetCardsRequestValidatorBase : AbstractValidator<GetCardsRequest>
    {
    public GetCardsRequestValidatorBase()
    {
    RuleFor(request => request.CRACKER_API_KEY).NotNull().NotEmpty().WithMessage("CRACKER_API_KEY is required");
    RuleFor(request => request.CoachName).NotNull().NotEmpty().WithMessage("CoachName is required");
    }
    }

    }

