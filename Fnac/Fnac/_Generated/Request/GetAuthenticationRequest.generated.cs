
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace FnacApp.Fnac
{
    public partial class GetAuthenticationRequest
    {
      public Auth Request {get; set; }

      public override bool Equals(object obj)
        {
            return obj is GetAuthenticationRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetAuthenticationRequest).GetHashCode();
                if(default != Request) hashCode = (hashCode * 397) ^ Request.GetHashCode();
                return hashCode;
            }
        }


    }



    public abstract class GetAuthenticationRequestValidatorBase : AbstractValidator<GetAuthenticationRequest>
    {
    public GetAuthenticationRequestValidatorBase()
    {
    RuleFor(request => request.Request).NotNull().WithMessage("Request is required");
    }
    }

    }

