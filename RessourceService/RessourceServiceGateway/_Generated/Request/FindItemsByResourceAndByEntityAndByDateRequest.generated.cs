
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace RessourceServiceApp.RessourceServiceGateway
{
    public partial class FindItemsByResourceAndByEntityAndByDateRequest
    {
      public string Resource {get; set; }
      public string Entity {get; set; }
      public DateTime Date {get; set; }

      public override bool Equals(object obj)
        {
            return obj is FindItemsByResourceAndByEntityAndByDateRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(FindItemsByResourceAndByEntityAndByDateRequest).GetHashCode();
                if(default != Resource) hashCode = (hashCode * 397) ^ Resource.GetHashCode();
                if(default != Entity) hashCode = (hashCode * 397) ^ Entity.GetHashCode();
                if(default != Date) hashCode = (hashCode * 397) ^ Date.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseFindItemsByResourceAndByEntityAndByDate400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseFindItemsByResourceAndByEntityAndByDate400Exception()
        : base() { }

    public HttpResponseFindItemsByResourceAndByEntityAndByDate400Exception(string message)
        : base(message) { }

    public HttpResponseFindItemsByResourceAndByEntityAndByDate400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public abstract class FindItemsByResourceAndByEntityAndByDateRequestValidatorBase : AbstractValidator<FindItemsByResourceAndByEntityAndByDateRequest>
    {
    public FindItemsByResourceAndByEntityAndByDateRequestValidatorBase()
    {
    RuleFor(request => request.Resource).NotNull().NotEmpty().WithMessage("Resource is required");
    RuleFor(request => request.Entity).NotNull().NotEmpty().WithMessage("Entity is required");
    RuleFor(request => request.Date).NotNull().NotEmpty().WithMessage("Date is required");
    }
    }

    }
