using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public interface IPetStoreService
    {

AddPet(AddPetRequest request);


UpdatePet(UpdatePetRequest request);


Task<> FindPetsByStatus(FindPetsByStatusRequest request);


Task<> FindPetsByTags(FindPetsByTagsRequest request);


Task GetPetById(GetPetByIdRequest request);


UpdatePetWithForm(UpdatePetWithFormRequest request);


DeletePet(DeletePetRequest request);


Task UploadFile(UploadFileRequest request);


Task<> GetInventory(GetInventoryRequest request);


Task PlaceOrder(PlaceOrderRequest request);


Task GetOrderById(GetOrderByIdRequest request);


DeleteOrder(DeleteOrderRequest request);


CreateUser(CreateUserRequest request);


CreateUsersWithArrayInput(CreateUsersWithArrayInputRequest request);


CreateUsersWithListInput(CreateUsersWithListInputRequest request);


Task<> LoginUser(LoginUserRequest request);


LogoutUser(LogoutUserRequest request);


Task GetUserByName(GetUserByNameRequest request);


UpdateUser(UpdateUserRequest request);


DeleteUser(DeleteUserRequest request);

    }
}
