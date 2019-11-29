
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class Pet
    {
public long Id {get; set; }
public Category Category {get; set; }
public string Name {get; set; }
public IEnumerable< string> PhotoUrls {get; set; }
public IEnumerable<Tag> Tags {get; set; }
public string Status {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(Pet).GetHashCode();
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                hashCode = (hashCode * 397) ^ Category.GetHashCode();
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                hashCode = (hashCode * 397) ^ PhotoUrls.GetHashCode();
                hashCode = (hashCode * 397) ^ Tags.GetHashCode();
                hashCode = (hashCode * 397) ^ Status.GetHashCode();
                return hashCode;
            }
        }
    }
}

