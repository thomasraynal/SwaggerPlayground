using Microsoft.Extensions.DependencyInjection;
using SwaggerPlayground.Modules.PetStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Tests
{
    public class TestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPetStoreService, PetStoreService>();
        }
    }
}
