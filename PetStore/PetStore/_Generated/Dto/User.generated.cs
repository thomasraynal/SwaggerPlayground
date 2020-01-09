
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace PetStoreApp.PetStore
{


    public partial class User
    {
      public long Id {get; set; }
      public string Username {get; set; }
      public string FirstName {get; set; }
      public string LastName {get; set; }
      public string Email {get; set; }
      public string Password {get; set; }
      public string Phone {get; set; }
      public int UserStatus {get; set; }

    }

    public abstract class UserValidatorBase : AbstractValidator<User>
    {
        public UserValidatorBase()
        {
        }
    }

}

