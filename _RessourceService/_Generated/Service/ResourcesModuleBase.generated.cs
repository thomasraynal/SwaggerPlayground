
using Nancy;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.Resources
{
    public abstract class ResourcesModuleBase : NancyModule
    {
        public ResourcesModuleBase(IResourcesService resourcesService) : base("/v1/data")
        {

           Get("/",  async (parameters, token) =>
            {
                ConfigureGetAvailableResourcesRequestRoute();

                return await this.EvaluateAndBind<GetAvailableResourcesRequest>(async (request) => await resourcesService.GetAvailableResources(request),  HttpStatusCode.OK );
            });


           Put("/",  async (parameters, token) =>
            {
                ConfigureStoreItemRequestRoute();

                return await this.EvaluateAndBind<StoreItemRequest>(async (request) => await resourcesService.StoreItem(request),  HttpStatusCode.Created );
            });


           Get("/resource/date",  async (parameters, token) =>
            {
                ConfigureFindItemByResourceAndByDateRequestRoute();

                return await this.EvaluateAndBind<FindItemByResourceAndByDateRequest>(async (request) => await resourcesService.FindItemByResourceAndByDate(request),  HttpStatusCode.OK );
            });


           Get("/resource/entity/date",  async (parameters, token) =>
            {
                ConfigureFindItemsByResourceAndByEntityAndByDateRequestRoute();

                return await this.EvaluateAndBind<FindItemsByResourceAndByEntityAndByDateRequest>(async (request) => await resourcesService.FindItemsByResourceAndByEntityAndByDate(request),  HttpStatusCode.OK );
            });

        }

        protected virtual void ConfigureGetAvailableResourcesRequestRoute()
        {
        }
        protected virtual void ConfigureStoreItemRequestRoute()
        {
        }
        protected virtual void ConfigureFindItemByResourceAndByDateRequestRoute()
        {
        }
        protected virtual void ConfigureFindItemsByResourceAndByEntityAndByDateRequestRoute()
        {
        }

    }
}
