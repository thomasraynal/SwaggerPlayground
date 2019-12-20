using Nancy;
using Nancy.ModelBinding;
using Nancy.Responses.Negotiation;
using Nancy.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerPlayground.Common
{
    public static class NancyNegociatorExtensions
    {

        private static string MakeError(ModelValidationResult modelValidationResult)
        {
            var errors = new List<string>();

            foreach (var validationError in modelValidationResult.Errors)
            {
                foreach (var error in validationError.Value)
                {
                    errors.Add($"{validationError.Key} : {error.ErrorMessage}");
                }
            }

            return errors.Aggregate((error1, error2) => $"{error1} | {error2}");

        }

        public static async Task<Negotiator> EvaluateAndBind<TRequest>(this NancyModule module, Func<TRequest, Task> success, HttpStatusCode onSuccessHttpCode = HttpStatusCode.OK) where TRequest : class
        {
            
            var request = module.BindAndValidate<TRequest>();

            if (!module.ModelValidationResult.IsValid)
            {
                var errors = MakeError(module.ModelValidationResult);

                throw new GenericBadRequest(errors);
            }

            await success(request);

            return await module.Negotiate.WithStatusCode(onSuccessHttpCode)
                                         .WithModel(string.Empty);

        }

        public static async Task<Negotiator> EvaluateAndBind<TRequest>(this NancyModule module, Func<TRequest, Task<object>> success, HttpStatusCode onSuccessHttpCode = HttpStatusCode.OK) where TRequest : class
        {

            var request = module.BindAndValidate<TRequest>();

            if (!module.ModelValidationResult.IsValid)
            {
                var errors = MakeError(module.ModelValidationResult);

                throw new GenericBadRequest(errors);
            }

            var result = await success(request);

            return await module.Negotiate.WithStatusCode(onSuccessHttpCode)
                                         .WithModel(result);
        }
    }
}
