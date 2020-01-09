
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace PetStoreApp.PetStore
{


    public partial class ApiResponse
    {
      public int Code {get; set; }
      public string Type {get; set; }
      public string Message {get; set; }

    }

    public abstract class ApiResponseValidatorBase : AbstractValidator<ApiResponse>
    {
        public ApiResponseValidatorBase()
        {
        }
    }

}


