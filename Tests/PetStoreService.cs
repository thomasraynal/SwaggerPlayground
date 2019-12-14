using SwaggerPlayground.Modules.PetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerPlayground.Tests
{
    public class PetStoreService : IPetStoreService
    {
        private List<Pet> _pets = new List<Pet>();

        public Task<Pet> AddPet(AddPetRequest request)
        {
            _pets.Add(request.Body);

            return Task.FromResult(request.Body);
        }

        public Task CreateUser(CreateUserRequest request)
        {
            throw new NotImplementedException();
        }

        public Task CreateUsersWithArrayInput(CreateUsersWithArrayInputRequest request)
        {
            throw new NotImplementedException();
        }

        public Task CreateUsersWithListInput(CreateUsersWithListInputRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(DeleteOrderRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeletePet(DeletePetRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(DeleteUserRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pet>> FindPetsByStatus(FindPetsByStatusRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pet>> FindPetsByTags(FindPetsByTagsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IEnumerable<(string, int)>>> GetInventory(GetInventoryRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderById(GetOrderByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Pet> GetPetById(GetPetByIdRequest request)
        {
            var result = _pets.FirstOrDefault(pet => pet.Id == request.PetId);

            return Task.FromResult(result);

        }

        public Task<User> GetUserByName(GetUserByNameRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<string> LoginUser(LoginUserRequest request)
        {
            throw new NotImplementedException();
        }

        public Task LogoutUser(LogoutUserRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Order> PlaceOrder(PlaceOrderRequest request)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePet(UpdatePetRequest request)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePetWithForm(UpdatePetWithFormRequest request)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(UpdateUserRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UploadFile(UploadFileRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
