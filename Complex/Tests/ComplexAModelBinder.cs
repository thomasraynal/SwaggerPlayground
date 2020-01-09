using ComplexApp.Complex;
using Nancy;
using Nancy.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Complex.Tests
{
    public class ComplexAModelBinder : IModelBinder
    {
        public object Bind(NancyContext context, Type modelType, object instance, BindingConfig configuration, params string[] blackList)
        {
            var reader = new StreamReader(context.Request.Body);
            var request = JsonConvert.DeserializeObject<PostComplexARequest>(reader.ReadToEnd());
            return request;
        }

        public bool CanBind(Type modelType)
        {
            return modelType == typeof(PostComplexARequest);
        }
    }
}
