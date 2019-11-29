
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class UploadFileRequest
    {
public long PetId {get; set; }
public string AdditionalMetadata {get; set; }
public Stream File {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(UploadFileRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ PetId.GetHashCode();
                hashCode = (hashCode * 397) ^ AdditionalMetadata.GetHashCode();
                hashCode = (hashCode * 397) ^ File.GetHashCode();
                return hashCode;
            }
        }


    }
}


