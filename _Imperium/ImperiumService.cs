﻿using SwaggerPlayground.Modules.Imperium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
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
