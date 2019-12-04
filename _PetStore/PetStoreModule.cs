
using Nancy;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public class PetStoreModule : NancyModule
    {
        public PetStoreModule(IPetStoreService petStoreService) : base("/v2")
        {

           Post("/pet",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<AddPetRequest>(async (request) => await petStoreService.AddPet(request), HttpStatusCode.Created);
            });


           Put("/pet",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<UpdatePetRequest>(async (request) => await petStoreService.UpdatePet(request), HttpStatusCode.Created);
            });


           Get("/pet/findByStatus",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<FindPetsByStatusRequest>(async (request) => await petStoreService.FindPetsByStatus(request), HttpStatusCode.Created);
            });


           Get("/pet/findByTags",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<FindPetsByTagsRequest>(async (request) => await petStoreService.FindPetsByTags(request), HttpStatusCode.Created);
            });


           Get("/pet/{petId}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<GetPetByIdRequest>(async (request) => await petStoreService.GetPetById(request), HttpStatusCode.Created);
            });


           Post("/pet/{petId}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<UpdatePetWithFormRequest>(async (request) => await petStoreService.UpdatePetWithForm(request), HttpStatusCode.Created);
            });


           Delete("/pet/{petId}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<DeletePetRequest>(async (request) => await petStoreService.DeletePet(request), HttpStatusCode.Created);
            });


           Post("/pet/{petId}/uploadImage",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<UploadFileRequest>(async (request) => await petStoreService.UploadFile(request), HttpStatusCode.Created);
            });


           Get("/store/inventory",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<GetInventoryRequest>(async (request) => await petStoreService.GetInventory(request), HttpStatusCode.Created);
            });


           Post("/store/order",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<PlaceOrderRequest>(async (request) => await petStoreService.PlaceOrder(request), HttpStatusCode.Created);
            });


           Get("/store/order/{orderId}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<GetOrderByIdRequest>(async (request) => await petStoreService.GetOrderById(request), HttpStatusCode.Created);
            });


           Delete("/store/order/{orderId}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<DeleteOrderRequest>(async (request) => await petStoreService.DeleteOrder(request), HttpStatusCode.Created);
            });


           Post("/user",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<CreateUserRequest>(async (request) => await petStoreService.CreateUser(request), HttpStatusCode.Created);
            });


           Post("/user/createWithArray",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<CreateUsersWithArrayInputRequest>(async (request) => await petStoreService.CreateUsersWithArrayInput(request), HttpStatusCode.Created);
            });


           Post("/user/createWithList",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<CreateUsersWithListInputRequest>(async (request) => await petStoreService.CreateUsersWithListInput(request), HttpStatusCode.Created);
            });


           Get("/user/login",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<LoginUserRequest>(async (request) => await petStoreService.LoginUser(request), HttpStatusCode.Created);
            });


           Get("/user/logout",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<LogoutUserRequest>(async (request) => await petStoreService.LogoutUser(request), HttpStatusCode.Created);
            });


           Get("/user/{username}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<GetUserByNameRequest>(async (request) => await petStoreService.GetUserByName(request), HttpStatusCode.Created);
            });


           Put("/user/{username}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<UpdateUserRequest>(async (request) => await petStoreService.UpdateUser(request), HttpStatusCode.Created);
            });


           Delete("/user/{username}",  async (parameters, token) =>
            {
                return await this.EvaluateAndBind<DeleteUserRequest>(async (request) => await petStoreService.DeleteUser(request), HttpStatusCode.Created);
            });

        }
    }
}
