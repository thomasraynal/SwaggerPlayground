using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResourceServiceApp.ResourceServiceGateway
{
    public interface IResourceServiceGatewayService
    {

Task< IEnumerable< string > > GetAvailableResources(GetAvailableResourcesRequest request);


Task StoreResourceItems(StoreResourceItemsRequest request);


Task< ResourceItems > FindResourceItemsByRessurceNameAndByDate(FindResourceItemsByRessurceNameAndByDateRequest request);


Task< ResourceItems > FindResourceItemsByResourceNameAndByEntityAndByDate(FindResourceItemsByResourceNameAndByEntityAndByDateRequest request);

    }
}
