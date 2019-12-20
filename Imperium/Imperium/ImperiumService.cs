using System;
using System.Threading.Tasks;

namespace ImperiumApp.Imperium
{
    public class ImperiumService : IImperiumService
    {
        public Task DeleteCurrentCollection(DeleteCurrentCollectionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task GetActiveCards(GetActiveCardsRequest request)
        {
            return Task.CompletedTask;
        }

        public Task GetCards(GetCardsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task OpenNewPack(OpenNewPackRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
