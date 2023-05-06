using MediatR;
using PetApi.Application.Commands;
using PetApi.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace PetApi.Application
{
    public class DeletePetHandler : IRequestHandler<DeletePetCommand, Unit>
    {
        private readonly PetDataStore _dataStore;

        public DeletePetHandler(PetDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public Task<Unit> Handle(DeletePetCommand request, CancellationToken cancellationToken)
        {
            _dataStore.DeletePet(request.Id);
            return Task.FromResult(Unit.Value);
        }
    }
}