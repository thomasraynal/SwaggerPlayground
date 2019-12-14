using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Common
{
    //https://bytefish.de/blog/consistent_error_handling_with_nancy/
    public interface IHasHttpServiceError
    {
        HttpServiceError HttpServiceError { get; }
    }
}
