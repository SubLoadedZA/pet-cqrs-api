using MediatR;
using PetApi.Application.Commands;
using PetApi.Domain;
using PetApi.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace PetApi.Application
{
    public class CreatePetHandler : IRequestHandler<CreatePetCommand, Pet>
    {
        private readonly PetDataStore _dataStore;

        public CreatePetHandler(PetDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public Task<Pet> Handle(CreatePetCommand request, CancellationToken cancellationToken)
        {
            var pet = new Pet(Guid.NewGuid(), request.Name, request.Species, request.BirthDate);
            _dataStore.AddPet(pet);
            return Task.FromResult(pet);
        }
    }
}