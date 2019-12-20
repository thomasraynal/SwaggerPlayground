using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwaggerPlayground.Modules.Imperium
{
    public class GetActiveCardsRequestModelBinder : IModelBinder
    {
        public object Bind(NancyContext context, Type modelType, object instance, BindingConfig configuration, params string[] blackList)
        {
            var request = (instance as GetActiveCardsRequest) ?? new GetActiveCardsRequest();

            request.CRACKER_API_KEY = context.Request.Headers[nameof(request.CRACKER_API_KEY)].FirstOrDefault();

            return request;
        }

        public bool CanBind(Type modelType)
        {
            return modelType == typeof(GetActiveCardsRequest);
        }
    }
}
