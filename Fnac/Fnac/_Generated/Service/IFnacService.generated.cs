using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FnacApp.Fnac
{
    public interface IFnacService
    {

Task< Auth_response > GetAuthentication(GetAuthenticationRequest request);


Task< Offers_update_response > PushOffersUpdate(PushOffersUpdateRequest request);


Task< Batch_status_response > GetBatchStatus(GetBatchStatusRequest request);

    }
}
