
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace ImperiumApp.Imperium
{


    public partial class Pack
    {
      public Pack_type Pack_type {get; set; }
      public Team Team {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is Pack && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Pack).GetHashCode();
//                if (default != Pack_type) hashCode = (hashCode * 397) ^ Pack_type.GetHashCode();
//                if (default != Team) hashCode = (hashCode * 397) ^ Team.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class PackValidatorBase : AbstractValidator<Pack>
    {
        public PackValidatorBase()
        {
                        RuleFor(dto => dto.Pack_type).NotNull().NotEmpty().WithMessage("Pack_type is required");
                        RuleFor(dto => dto.Team).NotNull().NotEmpty().WithMessage("Team is required");
        }
    }

}


