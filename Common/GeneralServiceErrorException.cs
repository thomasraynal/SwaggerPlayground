using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SwaggerPlayground.Common
{
    [Serializable]
    public class GeneralServiceErrorException : Exception, IHasHttpServiceError
    {
        public GeneralServiceErrorException(string message)
            : base(message)
        {

        }

        public GeneralServiceErrorException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        public HttpStatusCode HttpStatusCode => HttpStatusCode.InternalServerError;
    }
}
