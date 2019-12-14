using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SwaggerPlayground.Common
{
    public class HttpServiceError
    {
        public HttpServiceError(HttpStatusCode httpStatusCode, string details)
        {
            Details = details;
            HttpStatusCode = httpStatusCode;
        }

        public string Details { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
