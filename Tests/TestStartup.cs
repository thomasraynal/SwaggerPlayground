using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Owin;
using Nancy.Responses.Negotiation;
using Nancy.TinyIoc;
using SwaggerPlayground.Common;
using SwaggerPlayground.Modules.PetStore;
using SwaggerPlayground.Modules.Resources;
using System;

namespace SwaggerPlayground.Tests
{
    public class DemoBootstrapper : DefaultNancyBootstrapper
    {

        public DemoBootstrapper()
        {
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

        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            CustomErrorHandler.Enable(pipelines, container.Resolve<IResponseNegotiator>());
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<IPetStoreService, PetStoreService>();
            container.Register<IResourcesService, ResourcesService>();
        }
    }

    public class TestStartup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(configuration => configuration.UseNancy(options => options.Bootstrapper = new DemoBootstrapper()));
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
        }
    }
}
