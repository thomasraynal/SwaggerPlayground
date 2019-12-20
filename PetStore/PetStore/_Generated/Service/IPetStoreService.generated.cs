using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetStoreApp.PetStore
{
    public interface IPetStoreService
    {

Task< Pet > AddPet(AddPetRequest request);


Task UpdatePet(UpdatePetRequest request);


Task< IEnumerable<Pet> > FindPetsByStatus(FindPetsByStatusRequest request);


Task< IEnumerable<Pet> > FindPetsByTags(FindPetsByTagsRequest request);


Task< Pet > GetPetById(GetPetByIdRequest request);


Task UpdatePetWithForm(UpdatePetWithFormRequest request);


Task DeletePet(DeletePetRequest request);


Task< ApiResponse > UploadFile(UploadFileRequest request);


Task< IEnumerable< IEnumerable<(string, int )> > > GetInventory(GetInventoryRequest request);


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
