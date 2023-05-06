using MediatR;
using System;

namespace PetApi.Application.Commands
{
    public record UpdatePetCommand(Guid Id, string Name, string Species, DateTime BirthDate) : IRequest<Unit>;
}