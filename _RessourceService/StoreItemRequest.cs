
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.Resources
{
    public partial class StoreItemRequest
    {
      public ResourceItems ResourceItems {get; set; }

      public override bool Equals(object obj)
        {
            return obj is StoreItemRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(StoreItemRequest).GetHashCode();
                if(default != ResourceItems) hashCode = (hashCode * 397) ^ ResourceItems.GetHashCode();
                return hashCode;
            }
        }


    }


public class StoreItem400Exception : Exception, IHasHttpServiceError
{
    public StoreItem400Exception()
        : base() { }

    public StoreItem400Exception(string message)
        : base(message) { }

    public StoreItem400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public class StoreItemRequestValidator : AbstractValidator<StoreItemRequest>
    {
        public StoreItemRequestValidator()
        {
                    RuleFor(request => request.ResourceItems).NotNull().WithMessage("ResourceItems is required");
        }
    }

}

