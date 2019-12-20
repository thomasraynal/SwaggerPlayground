using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RessourceServiceApp.RessourceServiceGateway
{
    public class RessourceServiceGatewayService : IRessourceServiceGatewayService
    {
        public Task<ResourceItems> FindItemByResourceAndByDate(FindItemByResourceAndByDateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceItems> FindItemsByResourceAndByEntityAndByDate(FindItemsByResourceAndByEntityAndByDateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetAvailableResources(GetAvailableResourcesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task StoreItem(StoreItemRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
