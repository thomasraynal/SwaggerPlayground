
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.Resources
{
    public class FindItemByResourceAndByDateRequest
    {


                public string Resource {get; set;}


                public string Date {get; set;}



      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof( FindItemByResourceAndByDateRequest).GetHashCode();

                  hashCode = (hashCode * 397) ^ Resource.GetHashCode();
                  hashCode = (hashCode * 397) ^ Date.GetHashCode();

                return hashCode;
            }
        }


    }
}


