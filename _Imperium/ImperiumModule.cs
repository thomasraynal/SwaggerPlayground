
using Nancy;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.Imperium
{
    public class ImperiumModule : NancyModule
    {
        public ImperiumModule(IImperiumService imperiumService) : base("/api")
        {

           Get("/cracker/cards",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<GetActiveCardsRequest>(async (request) => await imperiumService.GetActiveCards(request),  HttpStatusCode.OK );
            });


           Get("/cracker/cards/{coachName}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<GetCardsRequest>(async (request) => await imperiumService.GetCards(request),  HttpStatusCode.OK );
            });


           Delete("/cracker/cards/{coachName}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<DeleteCurrentCollectionRequest>(async (request) => await imperiumService.DeleteCurrentCollection(request),  HttpStatusCode.OK );
            });


           Post("/cracker/cards/{coachName}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<OpenNewPackRequest>(async (request) => await imperiumService.OpenNewPack(request),  HttpStatusCode.OK );
            });

        }
    }
}
