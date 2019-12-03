using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public interface IPetStoreService
    {

Task AddPet(AddPetRequest request);


Task UpdatePet(UpdatePetRequest request);


Task FindPetsByStatus(FindPetsByStatusRequest request);


Task FindPetsByTags(FindPetsByTagsRequest request);


Task GetPetById(GetPetByIdRequest request);


Task UpdatePetWithForm(UpdatePetWithFormRequest request);


Task DeletePet(DeletePetRequest request);


Task UploadFile(UploadFileRequest request);


Task GetInventory(GetInventoryRequest request);


Task PlaceOrder(PlaceOrderRequest request);


Task GetOrderById(GetOrderByIdRequest request);


Task DeleteOrder(DeleteOrderRequest request);


Task CreateUser(CreateUserRequest request);


Task CreateUsersWithArrayInput(CreateUsersWithArrayInputRequest request);


Task CreateUsersWithListInput(CreateUsersWithListInputRequest request);


Task LoginUser(LoginUserRequest request);


Task LogoutUser(LogoutUserRequest request);


Task GetUserByName(GetUserByNameRequest request);


Task UpdateUser(UpdateUserRequest request);


Task DeleteUser(DeleteUserRequest request);

    }
}
