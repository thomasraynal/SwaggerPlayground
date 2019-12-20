using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.Imperium
{
    public interface IImperiumService
    {

Task GetActiveCards(GetActiveCardsRequest request);


Task GetCards(GetCardsRequest request);


Task DeleteCurrentCollection(DeleteCurrentCollectionRequest request);


Task OpenNewPack(OpenNewPackRequest request);

    }
}
