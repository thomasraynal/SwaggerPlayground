
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.Imperium
{
    public partial class OpenNewPackRequest
    {
      public string CRACKER_API_KEY {get; set; }
      public string CoachName {get; set; }
      public IEnumerable< object > Pack {get; set; }

      public override bool Equals(object obj)
        {
            return obj is OpenNewPackRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(OpenNewPackRequest).GetHashCode();
                if(default != CRACKER_API_KEY) hashCode = (hashCode * 397) ^ CRACKER_API_KEY.GetHashCode();
                if(default != CoachName) hashCode = (hashCode * 397) ^ CoachName.GetHashCode();
                if(default != Pack) hashCode = (hashCode * 397) ^ Pack.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseOpenNewPack401Exception : Exception, IHasHttpServiceError
{
    public HttpResponseOpenNewPack401Exception()
        : base() { }

    public HttpResponseOpenNewPack401Exception(string message)
        : base(message) { }

    public HttpResponseOpenNewPack401Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)401;

    public string Details => Message;
}


    public abstract class OpenNewPackRequestValidatorBase : AbstractValidator<OpenNewPackRequest>
    {
    public OpenNewPackRequestValidatorBase()
    {
    RuleFor(request => request.CRACKER_API_KEY).NotNull().NotEmpty().WithMessage("CRACKER_API_KEY is required");
    RuleFor(request => request.CoachName).NotNull().NotEmpty().WithMessage("CoachName is required");
    }
    }

    }
