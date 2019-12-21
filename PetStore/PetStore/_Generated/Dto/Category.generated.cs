
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace PetStoreApp.PetStore
{


    public partial class Category
    {
      public long Id {get; set; }
      public string Name {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is Category && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Category).GetHashCode();
//                if (default != Id) hashCode = (hashCode * 397) ^ Id.GetHashCode();
//                if (default != Name) hashCode = (hashCode * 397) ^ Name.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class CategoryValidatorBase : AbstractValidator<Category>
    {
        public CategoryValidatorBase()
        {
        }
    }

}

