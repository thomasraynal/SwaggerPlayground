
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace PetStoreApp.PetStore
{


    public partial class Tag
    {
      public long Id {get; set; }
      public string Name {get; set; }

    }

    public abstract class TagValidatorBase : AbstractValidator<Tag>
    {
        public TagValidatorBase()
        {
        }
    }

}

