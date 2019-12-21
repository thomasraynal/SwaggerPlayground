
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace FnacApp.Fnac
{
    public partial class GetBatchStatusRequest
    {
      public Batch_status Request {get; set; }

      public override bool Equals(object obj)
        {
            return obj is GetBatchStatusRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetBatchStatusRequest).GetHashCode();
                if(default != Request) hashCode = (hashCode * 397) ^ Request.GetHashCode();
                return hashCode;
            }
        }


    }



    public class GetBatchStatusRequestValidator : AbstractValidator<GetBatchStatusRequest>
    {
    public GetBatchStatusRequestValidator()
    {
    RuleFor(request => request.Request).NotNull().WithMessage("Request is required");
    }
    }

    }
