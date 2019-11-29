
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class ApiResponse
    {
public int Code {get; set; }
public string Type {get; set; }
public string Message {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(ApiResponse).GetHashCode();
                hashCode = (hashCode * 397) ^ Code.GetHashCode();
                hashCode = (hashCode * 397) ^ Type.GetHashCode();
                hashCode = (hashCode * 397) ^ Message.GetHashCode();
                return hashCode;
            }
        }
    }
}


