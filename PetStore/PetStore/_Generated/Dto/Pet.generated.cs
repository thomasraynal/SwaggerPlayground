
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace PetStoreApp.PetStore
{


    public partial class Pet
    {
      public long Id {get; set; }
      public Category Category {get; set; }
      public string Name {get; set; }
      public IEnumerable< string > PhotoUrls {get; set; }
      public IEnumerable<Tag> Tags {get; set; }
      public PetStatus PetStatus {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is Pet && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Pet).GetHashCode();
//                if (default != Id) hashCode = (hashCode * 397) ^ Id.GetHashCode();
//                if (default != Category) hashCode = (hashCode * 397) ^ Category.GetHashCode();
//                if (default != Name) hashCode = (hashCode * 397) ^ Name.GetHashCode();
//                if (default != PhotoUrls) hashCode = (hashCode * 397) ^ PhotoUrls.GetHashCode();
//                if (default != Tags) hashCode = (hashCode * 397) ^ Tags.GetHashCode();
//                if (default != PetStatus) hashCode = (hashCode * 397) ^ PetStatus.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class PetValidatorBase : AbstractValidator<Pet>
    {
        public PetValidatorBase()
        {
                        RuleFor(dto => dto.Name).NotNull().NotEmpty().WithMessage("Name is required");
                        RuleFor(dto => dto.PhotoUrls).NotNull().WithMessage("PhotoUrls is required");
        }
    }

}

