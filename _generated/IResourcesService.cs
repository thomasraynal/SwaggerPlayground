
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.Resources
{
    public interface IResourcesService
    {

        Task< IEnumerable< string> > GetAvailableResources(GetAvailableResourcesRequest request);


        Task StoreItem(StoreItemRequest request);


        Task<ResourceItems> FindItemByResourceAndByDate(FindItemByResourceAndByDateRequest request);


        Task<ResourceItems> FindItemsByResourceAndByEntityAndByDate(FindItemsByResourceAndByEntityAndByDateRequest request);

    }
}
