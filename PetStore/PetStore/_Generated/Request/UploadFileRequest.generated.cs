
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace PetStoreApp.PetStore
{
    public partial class UploadFileRequest
    {
      public long PetId {get; set; }
      public string AdditionalMetadata {get; set; }
      public HttpFile File {get; set; }

      public override bool Equals(object obj)
        {
            return obj is UploadFileRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(UploadFileRequest).GetHashCode();
                if(default != PetId) hashCode = (hashCode * 397) ^ PetId.GetHashCode();
                if(default != AdditionalMetadata) hashCode = (hashCode * 397) ^ AdditionalMetadata.GetHashCode();
                if(default != File) hashCode = (hashCode * 397) ^ File.GetHashCode();
                return hashCode;
            }
        }


    }



    public abstract class UploadFileRequestValidatorBase : AbstractValidator<UploadFileRequest>
    {
    public UploadFileRequestValidatorBase()
    {
    RuleFor(request => request.PetId).NotNull().WithMessage("PetId is required");
    }
    }

    }

