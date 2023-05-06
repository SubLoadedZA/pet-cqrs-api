using MediatR;
using System;

namespace PetApi.Application.Commands
{
    public record DeletePetCommand(Guid Id) : IRequest<Unit>;
}