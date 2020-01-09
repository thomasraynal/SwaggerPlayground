
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


