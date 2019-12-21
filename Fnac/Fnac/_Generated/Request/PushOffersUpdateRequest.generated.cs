
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace FnacApp.Fnac
{
    public partial class PushOffersUpdateRequest
    {
      public Offers_update Request {get; set; }

      public override bool Equals(object obj)
        {
            return obj is PushOffersUpdateRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(PushOffersUpdateRequest).GetHashCode();
                if(default != Request) hashCode = (hashCode * 397) ^ Request.GetHashCode();
                return hashCode;
            }
        }


    }



    public class PushOffersUpdateRequestValidator : AbstractValidator<PushOffersUpdateRequest>
    {
    public PushOffersUpdateRequestValidator()
    {
    RuleFor(request => request.Request).NotNull().WithMessage("Request is required");
    }
    }

    }

