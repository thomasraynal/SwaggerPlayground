
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace ResourceServiceApp.ResourceServiceGateway
{
    public partial class FindResourceItemsByRessurceNameAndByDateRequest
    {
      public string Resource {get; set; }
      public DateTime Date {get; set; }

      public override bool Equals(object obj)
        {
            return obj is FindResourceItemsByRessurceNameAndByDateRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(FindResourceItemsByRessurceNameAndByDateRequest).GetHashCode();
                if(default != Resource) hashCode = (hashCode * 397) ^ Resource.GetHashCode();
                if(default != Date) hashCode = (hashCode * 397) ^ Date.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseFindResourceItemsByRessurceNameAndByDate400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseFindResourceItemsByRessurceNameAndByDate400Exception()
        : base() { }

    public HttpResponseFindResourceItemsByRessurceNameAndByDate400Exception(string message)
        : base(message) { }

    public HttpResponseFindResourceItemsByRessurceNameAndByDate400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public class FindResourceItemsByRessurceNameAndByDateRequestValidator : AbstractValidator<FindResourceItemsByRessurceNameAndByDateRequest>
    {
    public FindResourceItemsByRessurceNameAndByDateRequestValidator()
    {
    RuleFor(request => request.Resource).NotNull().NotEmpty().WithMessage("Resource is required");
    RuleFor(request => request.Date).NotNull().NotEmpty().WithMessage("Date is required");
    }
    }

    }

