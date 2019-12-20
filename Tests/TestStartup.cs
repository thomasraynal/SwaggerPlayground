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


    public class TestStartup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(configuration => configuration.UseNancy(options => options.Bootstrapper = new TestBootstrapper()));
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
