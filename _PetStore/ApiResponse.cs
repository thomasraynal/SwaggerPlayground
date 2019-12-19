
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class ApiResponse
    {
      public int Code {get; set; }
      public string Type {get; set; }
      public string Message {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is ApiResponse && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(ApiResponse).GetHashCode();
//                if (default != Code) hashCode = (hashCode * 397) ^ Code.GetHashCode();
//                if (default != Type) hashCode = (hashCode * 397) ^ Type.GetHashCode();
//                if (default != Message) hashCode = (hashCode * 397) ^ Message.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class ApiResponseValidatorBase : AbstractValidator<ApiResponse>
    {
        public ApiResponseValidatorBase()
        {
        }
    }

}




