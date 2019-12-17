using Nancy;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Common
{
    //https://bytefish.de/blog/consistent_error_handling_with_nancy/
    public static class HttpServiceErrorUtilities
    {
        public static (HttpStatusCode httpStatusCode, string details) ExtractFromException(Exception exception)
        {
            
            var httpServiceError = exception as IHasHttpServiceError;

            if (httpServiceError != null)
            {
                return (httpServiceError.HttpStatusCode, httpServiceError.Details);
            }

            return (HttpStatusCode.InternalServerError, "An error has occured");
        }
    }
}
