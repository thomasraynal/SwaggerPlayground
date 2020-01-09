
using Nancy;
using SwaggerPlayground.Common;

namespace ResourceServiceApp.ResourceServiceGateway
{
    public abstract class ResourceServiceGatewayModuleBase : NancyModule
    {
        public ResourceServiceGatewayModuleBase(IResourceServiceGatewayService ResourceServiceGatewayService) : base("/v1/data")
        {

           Get("/data",  async (parameters, token) =>
            {
                ConfigureGetAvailableResourcesRequestRoute();

                return await this.EvaluateAndBind<GetAvailableResourcesRequest>(async (request) => await ResourceServiceGatewayService.GetAvailableResources(request),  HttpStatusCode.OK );
            });


           Put("/data",  async (parameters, token) =>
            {
                ConfigureStoreResourceItemsRequestRoute();

                return await this.EvaluateAndBind<StoreResourceItemsRequest>(async (request) => await ResourceServiceGatewayService.StoreResourceItems(request),  HttpStatusCode.Created );
            });


           Get("/data/resource/date",  async (parameters, token) =>
            {
                ConfigureFindResourceItemsByRessurceNameAndByDateRequestRoute();

                return await this.EvaluateAndBind<FindResourceItemsByRessurceNameAndByDateRequest>(async (request) => await ResourceServiceGatewayService.FindResourceItemsByRessurceNameAndByDate(request),  HttpStatusCode.OK );
            });


           Get("/data/resource/entity/date",  async (parameters, token) =>
            {
                ConfigureFindResourceItemsByResourceNameAndByEntityAndByDateRequestRoute();

                return await this.EvaluateAndBind<FindResourceItemsByResourceNameAndByEntityAndByDateRequest>(async (request) => await ResourceServiceGatewayService.FindResourceItemsByResourceNameAndByEntityAndByDate(request),  HttpStatusCode.OK );
            });

        }

        protected virtual void ConfigureGetAvailableResourcesRequestRoute()
        {
        }
        protected virtual void ConfigureStoreResourceItemsRequestRoute()
        {
        }
        protected virtual void ConfigureFindResourceItemsByRessurceNameAndByDateRequestRoute()
        {
        }
        protected virtual void ConfigureFindResourceItemsByResourceNameAndByEntityAndByDateRequestRoute()
        {
        }

    }
}
