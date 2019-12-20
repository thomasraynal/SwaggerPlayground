
using Nancy;
using SwaggerPlayground.Common;

namespace RessourceServiceApp.RessourceServiceGateway
{
    public abstract class RessourceServiceGatewayModuleBase : NancyModule
    {
        public RessourceServiceGatewayModuleBase(IRessourceServiceGatewayService RessourceServiceGatewayService) : base("/v1/data")
        {

           Get("/",  async (parameters, token) =>
            {
                ConfigureGetAvailableResourcesRequestRoute();

                return await this.EvaluateAndBind<GetAvailableResourcesRequest>(async (request) => await RessourceServiceGatewayService.GetAvailableResources(request),  HttpStatusCode.OK );
            });


           Put("/",  async (parameters, token) =>
            {
                ConfigureStoreItemRequestRoute();

                return await this.EvaluateAndBind<StoreItemRequest>(async (request) => await RessourceServiceGatewayService.StoreItem(request),  HttpStatusCode.Created );
            });


           Get("/resource/date",  async (parameters, token) =>
            {
                ConfigureFindItemByResourceAndByDateRequestRoute();

                return await this.EvaluateAndBind<FindItemByResourceAndByDateRequest>(async (request) => await RessourceServiceGatewayService.FindItemByResourceAndByDate(request),  HttpStatusCode.OK );
            });


           Get("/resource/entity/date",  async (parameters, token) =>
            {
                ConfigureFindItemsByResourceAndByEntityAndByDateRequestRoute();

                return await this.EvaluateAndBind<FindItemsByResourceAndByEntityAndByDateRequest>(async (request) => await RessourceServiceGatewayService.FindItemsByResourceAndByEntityAndByDate(request),  HttpStatusCode.OK );
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
