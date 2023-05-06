using MediatR;
using PetApi.Application.Queries;
using PetApi.Domain;
using PetApi.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PetApi.Application
{
    public class GetAllPetsHandler : IRequestHandler<GetAllPetsQuery, List<Pet>>
    {
        private readonly PetDataStore _dataStore;

        public GetAllPetsHandler(PetDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public Task<List<Pet>> Handle(GetAllPetsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataStore.GetAllPets());
        }
    }
}