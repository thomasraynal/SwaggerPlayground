
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace ResourceServiceApp.ResourceServiceGateway
{
    public partial class FindResourceItemsByResourceNameAndByEntityAndByDateRequest
    {
      public string Resource {get; set; }
      public DateTime Date {get; set; }

      public override bool Equals(object obj)
        {
            return obj is FindResourceItemsByResourceNameAndByEntityAndByDateRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(FindResourceItemsByResourceNameAndByEntityAndByDateRequest).GetHashCode();
                if(default != Resource) hashCode = (hashCode * 397) ^ Resource.GetHashCode();
                if(default != Date) hashCode = (hashCode * 397) ^ Date.GetHashCode();
                return hashCode;
            }
        }


    }


public class HttpResponseFindResourceItemsByResourceNameAndByEntityAndByDate400Exception : Exception, IHasHttpServiceError
{
    public HttpResponseFindResourceItemsByResourceNameAndByEntityAndByDate400Exception()
        : base() { }

    public HttpResponseFindResourceItemsByResourceNameAndByEntityAndByDate400Exception(string message)
        : base(message) { }

    public HttpResponseFindResourceItemsByResourceNameAndByEntityAndByDate400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public class FindResourceItemsByResourceNameAndByEntityAndByDateRequestValidator : AbstractValidator<FindResourceItemsByResourceNameAndByEntityAndByDateRequest>
    {
    public FindResourceItemsByResourceNameAndByEntityAndByDateRequestValidator()
    {
    RuleFor(request => request.Resource).NotNull().NotEmpty().WithMessage("Resource is required");
    RuleFor(request => request.Date).NotNull().NotEmpty().WithMessage("Date is required");
    }
    }

    }
