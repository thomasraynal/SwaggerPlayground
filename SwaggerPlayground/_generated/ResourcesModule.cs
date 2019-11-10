
using Microsoft.Extensions.Logging;
using Nancy;
using System;
using System.Collections.Generic;
using System.Text;


namespace SwaggerPlayground.Modules.Resources
{
    public class ResourcesModule : NancyModule
    {
        public ResourcesModule(IResourcesService resourcesService) : base("/v1/data")
        {

			Get("/",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<GetAvailableResourcesRequest>(async (request) => await Service.GetAvailableResources(request, Nancy.HttpStatusCode.Created));
            });


			Put("/",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<StoreItemRequest>(async (request) => await Service.StoreItem(request, Nancy.HttpStatusCode.Created));
            });


			Get("/resource/date",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<FindItemByResourceAndByDateRequest>(async (request) => await Service.FindItemByResourceAndByDate(request, Nancy.HttpStatusCode.Created));
            });


			Get("/resource/entity/date",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<FindItemsByResourceAndByEntityAndByDateRequest>(async (request) => await Service.FindItemsByResourceAndByEntityAndByDate(request, Nancy.HttpStatusCode.Created));
            });

        }
    }
}
