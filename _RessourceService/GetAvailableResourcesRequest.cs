
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.Resources
{
    public partial class GetAvailableResourcesRequest
    {

      public override bool Equals(object obj)
        {
            return obj is GetAvailableResourcesRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetAvailableResourcesRequest).GetHashCode();
                return hashCode;
            }
        }


    }



    public class GetAvailableResourcesRequestValidator : AbstractValidator<GetAvailableResourcesRequest>
    {
        public GetAvailableResourcesRequestValidator()
        {
        }
    }

}

