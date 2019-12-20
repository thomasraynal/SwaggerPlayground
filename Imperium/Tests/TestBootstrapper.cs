using FluentValidation;
using ImperiumApp.Imperium;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Responses.Negotiation;
using Nancy.TinyIoc;
using SwaggerPlayground.Common;
using System;
using System.Collections.Generic;

namespace Imperium.Tests
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
            ErrorHandler.Enable(pipelines, container.Resolve<IResponseNegotiator>());
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<IImperiumService, ImperiumService>();
        }
    }
}
