
using Nancy;
using SwaggerPlayground.Common;

namespace ComplexApp.Complex
{
    public abstract class ComplexModuleBase : NancyModule
    {
        public ComplexModuleBase(IComplexService complexService) : base("")
        {

           Post("/complexA",  async (parameters, token) =>
            {
                ConfigurePostComplexARequestRoute();

                return await this.EvaluateAndBind<PostComplexARequest>(async (request) => await complexService.PostComplexA(request),  HttpStatusCode.OK );
            });


           Post("/complexB",  async (parameters, token) =>
            {
                ConfigurePostComplexBRequestRoute();

                return await this.EvaluateAndBind<PostComplexBRequest>(async (request) => await complexService.PostComplexB(request),  HttpStatusCode.OK );
            });


           Post("/complexC",  async (parameters, token) =>
            {
                ConfigurePostComplexCRequestRoute();

                return await this.EvaluateAndBind<PostComplexCRequest>(async (request) => await complexService.PostComplexC(request),  HttpStatusCode.OK );
            });


           Post("/complexD",  async (parameters, token) =>
            {
                ConfigurePostComplexDRequestRoute();

                return await this.EvaluateAndBind<PostComplexDRequest>(async (request) => await complexService.PostComplexD(request),  HttpStatusCode.OK );
            });


           Post("/complexE",  async (parameters, token) =>
            {
                ConfigurePostComplexERequestRoute();

                return await this.EvaluateAndBind<PostComplexERequest>(async (request) => await complexService.PostComplexE(request),  HttpStatusCode.OK );
            });

        }

        protected virtual void ConfigurePostComplexARequestRoute()
        {
        }
        protected virtual void ConfigurePostComplexBRequestRoute()
        {
        }
        protected virtual void ConfigurePostComplexCRequestRoute()
        {
        }
        protected virtual void ConfigurePostComplexDRequestRoute()
        {
        }
        protected virtual void ConfigurePostComplexERequestRoute()
        {
        }

    }
}
