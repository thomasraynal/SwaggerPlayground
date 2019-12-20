using Nancy;
using Nancy.Bootstrapper;
using Nancy.Responses.Negotiation;
using System;

namespace SwaggerPlayground.Common
{
    //https://bytefish.de/blog/consistent_error_handling_with_nancy/
    public static class ErrorHandler
    {
   
        public static void Enable(IPipelines pipelines, IResponseNegotiator responseNegotiator)
        {
            pipelines.OnError += (context, exception) => HandleException(context, exception, responseNegotiator);
        }

        private static Response HandleException(NancyContext context, Exception exception, IResponseNegotiator responseNegotiator)
        {
            return CreateNegotiatedResponse(context, responseNegotiator, exception);
        }

        private static Response CreateNegotiatedResponse(NancyContext context, IResponseNegotiator responseNegotiator, Exception exception)
        {
            var (httpStatusCode, details) = HttpServiceErrorUtilities.ExtractFromException(exception);

            Negotiator negotiator = new Negotiator(context)
                .WithStatusCode(httpStatusCode)
                .WithModel(details);

            return responseNegotiator.NegotiateResponse(negotiator, context);
        }
    }
}
