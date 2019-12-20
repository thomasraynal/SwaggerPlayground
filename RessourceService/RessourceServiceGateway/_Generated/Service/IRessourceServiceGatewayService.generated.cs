using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RessourceServiceApp.RessourceServiceGateway
{
    public interface IRessourceServiceGatewayService
    {

Task< IEnumerable< string > > GetAvailableResources(GetAvailableResourcesRequest request);


Task StoreItem(StoreItemRequest request);


Task< ResourceItems > FindItemByResourceAndByDate(FindItemByResourceAndByDateRequest request);


Task< ResourceItems > FindItemsByResourceAndByEntityAndByDate(FindItemsByResourceAndByEntityAndByDateRequest request);

    }
}
