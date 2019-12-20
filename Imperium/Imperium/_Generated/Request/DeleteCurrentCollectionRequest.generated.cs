
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace ImperiumApp.Imperium
{
    public partial class DeleteCurrentCollectionRequest
    {
      public string CRACKER_API_KEY {get; set; }
      public string CoachName {get; set; }

      public override bool Equals(object obj)
        {
            return obj is DeleteCurrentCollectionRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(DeleteCurrentCollectionRequest).GetHashCode();
                if(default != CRACKER_API_KEY) hashCode = (hashCode * 397) ^ CRACKER_API_KEY.GetHashCode();
                if(default != CoachName) hashCode = (hashCode * 397) ^ CoachName.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseDeleteCurrentCollection401Exception : Exception, IHasHttpServiceError
{
    public HttpResponseDeleteCurrentCollection401Exception()
        : base() { }

    public HttpResponseDeleteCurrentCollection401Exception(string message)
        : base(message) { }

    public HttpResponseDeleteCurrentCollection401Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)401;

    public string Details => Message;
}


    public abstract class DeleteCurrentCollectionRequestValidatorBase : AbstractValidator<DeleteCurrentCollectionRequest>
    {
    public DeleteCurrentCollectionRequestValidatorBase()
    {
    RuleFor(request => request.CRACKER_API_KEY).NotNull().NotEmpty().WithMessage("CRACKER_API_KEY is required");
    RuleFor(request => request.CoachName).NotNull().NotEmpty().WithMessage("CoachName is required");
    }
    }

    }

