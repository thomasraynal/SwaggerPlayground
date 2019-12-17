
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;
using FluentValidation;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class DeletePetRequest
    {
      public string Api_key {get; set; }
      public long PetId {get; set; }

      public override bool Equals(object obj)
        {
            return obj is DeletePetRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(DeletePetRequest).GetHashCode();
                if(default != Api_key) hashCode = (hashCode * 397) ^ Api_key.GetHashCode();
                if(default != PetId) hashCode = (hashCode * 397) ^ PetId.GetHashCode();
                return hashCode;
            }
        }


    }


public class DeletePet400Exception : Exception, IHasHttpServiceError
{
    public DeletePet400Exception()
        : base() { }

    public DeletePet400Exception(string message)
        : base(message) { }

    public DeletePet400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}


    public class DeletePetRequestValidator : AbstractValidator<DeletePetRequest>
    {
        public DeletePetRequestValidator()
        {
                    RuleFor(request => request.PetId).NotNull().WithMessage("PetId is required");
        }
    }

}

