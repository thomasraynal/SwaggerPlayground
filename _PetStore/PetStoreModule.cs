
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Security;
using Nancy.TinyIoc;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public abstract class PetStoreModuleBase : NancyModule
    {

            public PetStoreModuleBase(IPetStoreService petStoreService) : base("/v2")
        {

           Post("/pet",  async (parameters, token) =>
            {
                ConfigureAddPetRequestRoute();

                return await this.EvaluateAndBind<AddPetRequest>(async (request) => await petStoreService.AddPet(request),  HttpStatusCode.Created );
            });


           Put("/pet",  async (parameters, token) =>
            {
                ConfigureUpdatePetRequestRoute();

                return await this.EvaluateAndBind<UpdatePetRequest>(async (request) => await petStoreService.UpdatePet(request),  HttpStatusCode.OK );
            });


           Get("/pet/findByStatus",  async (parameters, token) =>
            {
                ConfigureFindPetsByStatusRequestRoute();

                return await this.EvaluateAndBind<FindPetsByStatusRequest>(async (request) => await petStoreService.FindPetsByStatus(request),  HttpStatusCode.OK );
            });


           Get("/pet/findByTags",  async (parameters, token) =>
            {
                ConfigureFindPetsByTagsRequestRoute();

                return await this.EvaluateAndBind<FindPetsByTagsRequest>(async (request) => await petStoreService.FindPetsByTags(request),  HttpStatusCode.OK );
            });


           Get("/pet/{petId}",  async (parameters, token) =>
            {
                ConfigureGetPetByIdRequestRoute();

                return await this.EvaluateAndBind<GetPetByIdRequest>(async (request) => await petStoreService.GetPetById(request),  HttpStatusCode.OK );
            });


           Post("/pet/{petId}",  async (parameters, token) =>
            {
                ConfigureUpdatePetWithFormRequestRoute();

                return await this.EvaluateAndBind<UpdatePetWithFormRequest>(async (request) => await petStoreService.UpdatePetWithForm(request),  HttpStatusCode.OK );
            });


           Delete("/pet/{petId}",  async (parameters, token) =>
            {
                ConfigureDeletePetRequestRoute();

                this.RequiresAuthentication();

                return await this.EvaluateAndBind<DeletePetRequest>(async (request) => await petStoreService.DeletePet(request),  HttpStatusCode.OK );
            });


           Post("/pet/{petId}/uploadImage",  async (parameters, token) =>
            {
                ConfigureUploadFileRequestRoute();

                return await this.EvaluateAndBind<UploadFileRequest>(async (request) => await petStoreService.UploadFile(request),  HttpStatusCode.OK );
            });


           Get("/store/inventory",  async (parameters, token) =>
            {
                ConfigureGetInventoryRequestRoute();

                return await this.EvaluateAndBind<GetInventoryRequest>(async (request) => await petStoreService.GetInventory(request),  HttpStatusCode.OK );
            });


           Post("/store/order",  async (parameters, token) =>
            {
                ConfigurePlaceOrderRequestRoute();

                return await this.EvaluateAndBind<PlaceOrderRequest>(async (request) => await petStoreService.PlaceOrder(request),  HttpStatusCode.OK );
            });


           Get("/store/order/{orderId}",  async (parameters, token) =>
            {
                ConfigureGetOrderByIdRequestRoute();

                return await this.EvaluateAndBind<GetOrderByIdRequest>(async (request) => await petStoreService.GetOrderById(request),  HttpStatusCode.OK );
            });


           Delete("/store/order/{orderId}",  async (parameters, token) =>
            {
                ConfigureDeleteOrderRequestRoute();

                return await this.EvaluateAndBind<DeleteOrderRequest>(async (request) => await petStoreService.DeleteOrder(request),  HttpStatusCode.OK );
            });


           Post("/user",  async (parameters, token) =>
            {
                ConfigureCreateUserRequestRoute();

                return await this.EvaluateAndBind<CreateUserRequest>(async (request) => await petStoreService.CreateUser(request),  HttpStatusCode.OK );
            });


           Post("/user/createWithArray",  async (parameters, token) =>
            {
                ConfigureCreateUsersWithArrayInputRequestRoute();

                return await this.EvaluateAndBind<CreateUsersWithArrayInputRequest>(async (request) => await petStoreService.CreateUsersWithArrayInput(request),  HttpStatusCode.OK );
            });


           Post("/user/createWithList",  async (parameters, token) =>
            {
                ConfigureCreateUsersWithListInputRequestRoute();

                return await this.EvaluateAndBind<CreateUsersWithListInputRequest>(async (request) => await petStoreService.CreateUsersWithListInput(request),  HttpStatusCode.OK );
            });


           Get("/user/login",  async (parameters, token) =>
            {
                ConfigureLoginUserRequestRoute();

                return await this.EvaluateAndBind<LoginUserRequest>(async (request) => await petStoreService.LoginUser(request),  HttpStatusCode.OK );
            });


           Get("/user/logout",  async (parameters, token) =>
            {
                ConfigureLogoutUserRequestRoute();

                return await this.EvaluateAndBind<LogoutUserRequest>(async (request) => await petStoreService.LogoutUser(request),  HttpStatusCode.OK );
            });


           Get("/user/{username}",  async (parameters, token) =>
            {
                ConfigureGetUserByNameRequestRoute();

                return await this.EvaluateAndBind<GetUserByNameRequest>(async (request) => await petStoreService.GetUserByName(request),  HttpStatusCode.OK );
            });


           Put("/user/{username}",  async (parameters, token) =>
            {
                ConfigureUpdateUserRequestRoute();

                return await this.EvaluateAndBind<UpdateUserRequest>(async (request) => await petStoreService.UpdateUser(request),  HttpStatusCode.OK );
            });


           Delete("/user/{username}",  async (parameters, token) =>
            {
                ConfigureDeleteUserRequestRoute();

                return await this.EvaluateAndBind<DeleteUserRequest>(async (request) => await petStoreService.DeleteUser(request),  HttpStatusCode.OK );
            });

        }

        protected virtual void ConfigureAddPetRequestRoute()
        {
        }
        protected virtual void ConfigureUpdatePetRequestRoute()
        {
        }
        protected virtual void ConfigureFindPetsByStatusRequestRoute()
        {
        }
        protected virtual void ConfigureFindPetsByTagsRequestRoute()
        {
        }
        protected virtual void ConfigureGetPetByIdRequestRoute()
        {
        }
        protected virtual void ConfigureUpdatePetWithFormRequestRoute()
        {
        }
        protected virtual void ConfigureDeletePetRequestRoute()
        {
        }
        protected virtual void ConfigureUploadFileRequestRoute()
        {
        }
        protected virtual void ConfigureGetInventoryRequestRoute()
        {
        }
        protected virtual void ConfigurePlaceOrderRequestRoute()
        {
        }
        protected virtual void ConfigureGetOrderByIdRequestRoute()
        {
        }
        protected virtual void ConfigureDeleteOrderRequestRoute()
        {
        }
        protected virtual void ConfigureCreateUserRequestRoute()
        {
        }
        protected virtual void ConfigureCreateUsersWithArrayInputRequestRoute()
        {
        }
        protected virtual void ConfigureCreateUsersWithListInputRequestRoute()
        {
        }
        protected virtual void ConfigureLoginUserRequestRoute()
        {
        }
        protected virtual void ConfigureLogoutUserRequestRoute()
        {
        }
        protected virtual void ConfigureGetUserByNameRequestRoute()
        {
        }
        protected virtual void ConfigureUpdateUserRequestRoute()
        {
        }
        protected virtual void ConfigureDeleteUserRequestRoute()
        {
        }

    }
}
