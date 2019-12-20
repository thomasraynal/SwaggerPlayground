
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace PetStoreApp.PetStore
{
    public partial class CreateUsersWithArrayInputRequest
    {
      public IEnumerable<User> Body {get; set; }

      public override bool Equals(object obj)
        {
            return obj is CreateUsersWithArrayInputRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(CreateUsersWithArrayInputRequest).GetHashCode();
                if(default != Body) hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }



    public abstract class CreateUsersWithArrayInputRequestValidatorBase : AbstractValidator<CreateUsersWithArrayInputRequest>
    {
    public CreateUsersWithArrayInputRequestValidatorBase()
    {
    }
    }

    }

