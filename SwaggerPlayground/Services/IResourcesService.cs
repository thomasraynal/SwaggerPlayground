using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerPlayground.Services
{
    public interface IResourcesService
    {
    
        Task<ResourceDescriptor> GetResource(GetResourceRequest request);

    
        Task<IEnumerable<ResourceDescriptor>> GetAvailableIdsForDate(string Resource, DateTime date);

       
        Task<IEnumerable<ResourceDescriptor>> GetAvailableDatesForId(string Resource, String id);

  
        Task<IEnumerable<String>> GetAvailableResources();

     
        Task<string[]> GetAvailableResources(string Resource);

        Task<bool> StoreResource(StoreResourceDescriptor payload);
    }
}
