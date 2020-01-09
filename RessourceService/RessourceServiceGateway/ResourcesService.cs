using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResourceServiceApp.ResourceServiceGateway
{
    public class RessourceServiceGatewayService : IResourceServiceGatewayService
    {
        public Task<ResourceItems> FindResourceItemsByResourceNameAndByEntityAndByDate(FindResourceItemsByResourceNameAndByEntityAndByDateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceItems> FindResourceItemsByRessurceNameAndByDate(FindResourceItemsByRessurceNameAndByDateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetAvailableResources(GetAvailableResourcesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task StoreResourceItems(StoreResourceItemsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
