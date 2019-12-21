
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace ComplexApp.Complex
{
    public partial class PostComplexERequest
    {
      public ComplexObjectE Request {get; set; }

      public override bool Equals(object obj)
        {
            return obj is PostComplexERequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(PostComplexERequest).GetHashCode();
                if(default != Request) hashCode = (hashCode * 397) ^ Request.GetHashCode();
                return hashCode;
            }
        }


    }



    public class PostComplexERequestValidator : AbstractValidator<PostComplexERequest>
    {
    public PostComplexERequestValidator()
    {
    RuleFor(request => request.Request).NotNull().WithMessage("Request is required");
    }
    }

    }
