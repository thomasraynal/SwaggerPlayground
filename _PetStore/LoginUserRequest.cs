
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class LoginUserRequest
    {
      public string Username {get; set; }
      public string Password {get; set; }

      public override bool Equals(object obj)
        {
            return obj is LoginUserRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(LoginUserRequest).GetHashCode();
                if(default != Username) hashCode = (hashCode * 397) ^ Username.GetHashCode();
                if(default != Password) hashCode = (hashCode * 397) ^ Password.GetHashCode();
                return hashCode;
            }
        }


    }


public class LoginUser400Exception : Exception, IHasHttpServiceError
{
    public LoginUser400Exception()
        : base() { }

    public LoginUser400Exception(string message)
        : base(message) { }

    public LoginUser400Exception(string message, Exception innerException)
        : base(message, innerException) { }

    public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

    public string Details => Message;
}



}


