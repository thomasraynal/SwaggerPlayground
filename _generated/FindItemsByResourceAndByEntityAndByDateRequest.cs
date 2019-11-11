
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.Resources
{
    public class FindItemsByResourceAndByEntityAndByDateRequest
    {


 public         string
 Resource  {get;set;}


 public         string
 Entity  {get;set;}


 public         DateTime
 Date  {get;set;}



      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof( FindItemsByResourceAndByEntityAndByDateRequest).GetHashCode();

                  hashCode = (hashCode * 397) ^ Resource.GetHashCode();
                  hashCode = (hashCode * 397) ^ Entity.GetHashCode();
                  hashCode = (hashCode * 397) ^ Date.GetHashCode();

                return hashCode;
            }
        }


    }
}


