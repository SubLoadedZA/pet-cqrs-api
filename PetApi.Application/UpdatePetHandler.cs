using MediatR;
using PetApi.Application.Commands;
using PetApi.Domain;
using PetApi.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace PetApi.Application
{
    public class UpdatePetHandler : IRequestHandler<UpdatePetCommand, Unit>
    {
        private readonly PetDataStore _dataStore;

        public UpdatePetHandler(PetDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public Task<Unit> Handle(UpdatePetCommand request, CancellationToken cancellationToken)
        {
            var pet = new Pet(request.Id, request.Name, request.Species, request.BirthDate);
            _dataStore.UpdatePet(pet);
            return Task.FromResult(Unit.Value);
        }
    }
}