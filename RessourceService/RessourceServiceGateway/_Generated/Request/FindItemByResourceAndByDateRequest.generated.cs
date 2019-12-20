
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace RessourceServiceApp.RessourceServiceGateway
{
    public partial class FindItemByResourceAndByDateRequest
    {
      public string Resource {get; set; }
      public DateTime Date {get; set; }

      public override bool Equals(object obj)
        {
            return obj is FindItemByResourceAndByDateRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(FindItemByResourceAndByDateRequest).GetHashCode();
                if(default != Resource) hashCode = (hashCode * 397) ^ Resource.GetHashCode();
                if(default != Date) hashCode = (hashCode * 397) ^ Date.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseFindItemByResourceAndByDate400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseFindItemByResourceAndByDate400Exception()
        : base() { }

    public HttpResponseFindItemByResourceAndByDate400Exception(string message)
        : base(message) { }

    public HttpResponseFindItemByResourceAndByDate400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public abstract class FindItemByResourceAndByDateRequestValidatorBase : AbstractValidator<FindItemByResourceAndByDateRequest>
    {
    public FindItemByResourceAndByDateRequestValidatorBase()
    {
    RuleFor(request => request.Resource).NotNull().NotEmpty().WithMessage("Resource is required");
    RuleFor(request => request.Date).NotNull().NotEmpty().WithMessage("Date is required");
    }
    }

    }

