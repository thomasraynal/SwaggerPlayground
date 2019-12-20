using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreApp.PetStore
{
    public class PetValidator : PetValidatorBase
    {
        public PetValidator()
        {
            RuleFor(dto => dto.Category).Must(category=> category.Name != "ThisCategoryIsNotAllowed") .WithMessage("Category must be allowed");
        }
    }

    public partial class Pet
    {
        public override bool Equals(object obj)
        {
            return obj is Pet && obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(Pet).GetHashCode();
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
