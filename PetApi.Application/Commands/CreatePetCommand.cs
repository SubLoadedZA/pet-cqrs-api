using MediatR;
using PetApi.Domain;
using System;

namespace PetApi.Application.Commands
{
    public record CreatePetCommand(string Name, string Species, DateTime BirthDate) : IRequest<Pet>;
}