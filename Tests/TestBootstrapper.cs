using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Owin;
using Nancy.Responses.Negotiation;
using Nancy.TinyIoc;
using SwaggerPlayground.Common;
using SwaggerPlayground.Modules.Imperium;
using SwaggerPlayground.Modules.PetStore;
using SwaggerPlayground.Modules.Resources;
using System;
using System.Collections.Generic;

namespace SwaggerPlayground.Tests
{
    public class TestBootstrapper : DefaultNancyBootstrapper
    {

        public TestBootstrapper()
        {
            ValidatorOptions.LanguageManager.Enabled = false;
        }

        protected override Func<ITypeCatalog, NancyInternalConfiguration> InternalConfiguration
        {
            get
            {
                return NancyInternalConfiguration.WithOverrides(
                       (configuration) =>
                       {
                           configuration.ResponseProcessors.Clear();
                           configuration.ResponseProcessors.Add(typeof(JsonProcessor));
                       });
            }

        }

        protected override IEnumerable<Type> ModelBinders
        {
            get
            {
                return new[] { typeof(GetActiveCardsRequestModelBinder) };
            }
        }

        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            CustomErrorHandler.Enable(pipelines, container.Resolve<IResponseNegotiator>());
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<IPetStoreService, PetStoreService>();
            container.Register<IResourcesService, ResourcesService>();
            container.Register<IImperiumService, ImperiumService>();
        }
    }
}
