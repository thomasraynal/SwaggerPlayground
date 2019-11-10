using Microsoft.Extensions.Logging;
using Nancy;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Services
{
    public class ResourceModule : NancyModule
    {

        public ResourceModule(IResourcesService ResourceService) : base("/data")
        {
            Get("/{Resource}/{date}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<GetResourceRequest>(async (request) => await ResourceService.GetResource(request));
            });

            Get("/{Resource}/{id}/{date}",async (parameters, token) =>
            {
                return await this.EvaluateAndBind<GetResourceRequest>(async (request) => await ResourceService.GetResource(request));
            });

            Get("/{Resource}", async (parameters, token) =>
            {
                return await ResourceService.GetAvailableResources(parameters.Resource);
            });

            Get("/", async (parameters, token) =>
            {
                return await ResourceService.GetAvailableResources();
            });

            Put("/", async (parameters, token) =>
           {
               return await this.EvaluateAndBind<StoreResourceDescriptor>(async (request) => await ResourceService.StoreResource(request), Nancy.HttpStatusCode.Created);
           });
        }

    }
}
