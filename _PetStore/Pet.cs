
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class Pet
    {
      public long Id {get; set; }
      public Category Category {get; set; }
      public string Name {get; set; }
      public IEnumerable< string > PhotoUrls {get; set; }
      public IEnumerable<Tag> Tags {get; set; }
      public Status Status {get; set; }

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
//                if (default != Status) hashCode = (hashCode * 397) ^ Status.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public class PetValidator : AbstractValidator<Pet>
    {
        public PetValidator()
        {

                     RuleFor(dto => dto.Name).NotNull().WithMessage("Name is required");

                     RuleFor(dto => dto.PhotoUrls).NotNull().WithMessage("PhotoUrls is required");
        }
    }

}



