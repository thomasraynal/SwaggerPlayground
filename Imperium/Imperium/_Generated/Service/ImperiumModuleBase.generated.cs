
using Nancy;
using SwaggerPlayground.Common;

namespace ImperiumApp.Imperium
{
    public abstract class ImperiumModuleBase : NancyModule
    {
        public ImperiumModuleBase(IImperiumService imperiumService) : base("/api")
        {

           Get("/cracker/cards",  async (parameters, token) =>
            {
                ConfigureGetActiveCardsRequestRoute();

                return await this.EvaluateAndBind<GetActiveCardsRequest>(async (request) => await imperiumService.GetActiveCards(request),  HttpStatusCode.OK );
            });


           Get("/cracker/cards/{coachName}",  async (parameters, token) =>
            {
                ConfigureGetCardsRequestRoute();

                return await this.EvaluateAndBind<GetCardsRequest>(async (request) => await imperiumService.GetCards(request),  HttpStatusCode.OK );
            });


           Delete("/cracker/cards/{coachName}",  async (parameters, token) =>
            {
                ConfigureDeleteCurrentCollectionRequestRoute();

                return await this.EvaluateAndBind<DeleteCurrentCollectionRequest>(async (request) => await imperiumService.DeleteCurrentCollection(request),  HttpStatusCode.OK );
            });


           Post("/cracker/cards/{coachName}",  async (parameters, token) =>
            {
                ConfigureOpenNewPackRequestRoute();

                return await this.EvaluateAndBind<OpenNewPackRequest>(async (request) => await imperiumService.OpenNewPack(request),  HttpStatusCode.OK );
            });

        }

        protected virtual void ConfigureGetActiveCardsRequestRoute()
        {
        }
        protected virtual void ConfigureGetCardsRequestRoute()
        {
        }
        protected virtual void ConfigureDeleteCurrentCollectionRequestRoute()
        {
        }
        protected virtual void ConfigureOpenNewPackRequestRoute()
        {
        }

    }
}
