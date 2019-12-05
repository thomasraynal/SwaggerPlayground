using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public interface IPetStoreService
    {

Task AddPet(AddPetRequest request);


Task UpdatePet(UpdatePetRequest request);


Task< IEnumerable<Pet> > FindPetsByStatus(FindPetsByStatusRequest request);


Task< IEnumerable<Pet> > FindPetsByTags(FindPetsByTagsRequest request);


Task< Pet > GetPetById(GetPetByIdRequest request);


Task UpdatePetWithForm(UpdatePetWithFormRequest request);


Task DeletePet(DeletePetRequest request);


Task< ApiResponse > UploadFile(UploadFileRequest request);


Task< object > GetInventory(GetInventoryRequest request);


Task< Order > PlaceOrder(PlaceOrderRequest request);


Task< Order > GetOrderById(GetOrderByIdRequest request);


Task DeleteOrder(DeleteOrderRequest request);


Task CreateUser(CreateUserRequest request);


Task CreateUsersWithArrayInput(CreateUsersWithArrayInputRequest request);


Task CreateUsersWithListInput(CreateUsersWithListInputRequest request);


Task< string > LoginUser(LoginUserRequest request);


Task LogoutUser(LogoutUserRequest request);


Task< User > GetUserByName(GetUserByNameRequest request);


Task UpdateUser(UpdateUserRequest request);


Task DeleteUser(DeleteUserRequest request);

    }
}
