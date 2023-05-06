using MediatR;
using PetApi.Application.Queries;
using PetApi.Domain;
using PetApi.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace PetApi.Application
{
    public class GetPetByIdHandler : IRequestHandler<GetPetByIdQuery, Pet>
    {
        private readonly PetDataStore _dataStore;

        public GetPetByIdHandler(PetDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public Task<Pet> Handle(GetPetByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataStore.GetPetById(request.Id));
        }
    }
}