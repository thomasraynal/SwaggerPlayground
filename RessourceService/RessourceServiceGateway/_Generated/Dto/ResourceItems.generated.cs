
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace ResourceServiceApp.ResourceServiceGateway
{


    public partial class ResourceItems
    {
      public IEnumerable< object > Items {get; set; }

    }

    public abstract class ResourceItemsValidatorBase : AbstractValidator<ResourceItems>
    {
        public ResourceItemsValidatorBase()
        {
        }
    }

}


