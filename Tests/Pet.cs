using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Modules.PetStore
{
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
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
