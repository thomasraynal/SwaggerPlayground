using Microsoft.Extensions.Logging;
using Nancy;
using Nancy.ModelBinding;
using Nancy.Responses.Negotiation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerPlayground.Services
{
    public static class NancyNegociatorExtensions
    {

        public static async Task<Negotiator> EvaluateAndBind<TRequest>(this NancyModule module, Func<TRequest, Task<object>> success, HttpStatusCode OnSuccess = HttpStatusCode.OK) where TRequest : class
        {
            var request = module.BindAndValidate<TRequest>();

            if (!module.ModelValidationResult.IsValid)
            {
                return module.Negotiate.WithStatusCode(HttpStatusCode.BadRequest)
                                       .WithModel(module.ModelValidationResult.FormattedErrors);
            }

            var result = await success(request);

            return await module.Negotiate.WithStatusCode(OnSuccess)
                             .WithModel(result);

        }
    }
}
