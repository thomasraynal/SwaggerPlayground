using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerPlayground.Services
{
    public interface IResourcesService
    {
    
        Task<ResourceDescriptor> GetResource(GetResourceRequest request);

        Task<IEnumerable<ResourceDescriptor>> GetAvailableIdsForDate(FindItemByResourceAndByDateRequest request);

        Task<IEnumerable<ResourceDescriptor>> GetAvailableDatesForId(FindItemsByResourceAndByEntityAndByDateRequest request);

        Task<IEnumerable<string>> GetAvailableResources(GetAvailableResourcesRequest getAvailableResourcesRequest);

        Task StoreResource(StoreItemRequest payload);
    }
}
