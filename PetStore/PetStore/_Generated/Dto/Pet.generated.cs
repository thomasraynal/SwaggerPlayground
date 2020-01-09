
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

