using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Nancy.Owin;

namespace Imperium.Tests
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
