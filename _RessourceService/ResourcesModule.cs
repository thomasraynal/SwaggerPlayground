
using Nancy;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.Resources
{
    public class ResourcesModule : NancyModule
    {
        public ResourcesModule(IResourcesService resourcesService) : base("/v1/data")
        {

           Get("/",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<GetAvailableResourcesRequest>(async (request) => await resourcesService.GetAvailableResources(request), HttpStatusCode.Created);
            });


           Put("/",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<StoreItemRequest>(async (request) => await resourcesService.StoreItem(request), HttpStatusCode.Created);
            });


           Get("/resource/date",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<FindItemByResourceAndByDateRequest>(async (request) => await resourcesService.FindItemByResourceAndByDate(request), HttpStatusCode.Created);
            });


           Get("/resource/entity/date",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<FindItemsByResourceAndByEntityAndByDateRequest>(async (request) => await resourcesService.FindItemsByResourceAndByEntityAndByDate(request), HttpStatusCode.Created);
            });

        }
    }
}
