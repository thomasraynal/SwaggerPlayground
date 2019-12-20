
using Nancy;
using SwaggerPlayground.Common;

namespace FnacApp.Fnac
{
    public abstract class FnacModuleBase : NancyModule
    {
        public FnacModuleBase(IFnacService fnacService) : base("/api.php")
        {

           Post("/auth",  async (parameters, token) =>
            {
                ConfigureGetAuthenticationRequestRoute();

                return await this.EvaluateAndBind<GetAuthenticationRequest>(async (request) => await fnacService.GetAuthentication(request),  HttpStatusCode.OK );
            });


           Post("/offers_update",  async (parameters, token) =>
            {
                ConfigurePushOffersUpdateRequestRoute();

                return await this.EvaluateAndBind<PushOffersUpdateRequest>(async (request) => await fnacService.PushOffersUpdate(request),  HttpStatusCode.OK );
            });


           Post("/batch_status",  async (parameters, token) =>
            {
                ConfigureGetBatchStatusRequestRoute();

                return await this.EvaluateAndBind<GetBatchStatusRequest>(async (request) => await fnacService.GetBatchStatus(request),  HttpStatusCode.OK );
            });

        }

        protected virtual void ConfigureGetAuthenticationRequestRoute()
        {
        }
        protected virtual void ConfigurePushOffersUpdateRequestRoute()
        {
        }
        protected virtual void ConfigureGetBatchStatusRequestRoute()
        {
        }

    }
}
