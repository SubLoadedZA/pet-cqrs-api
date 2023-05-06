using MediatR;
using PetApi.Domain;
using System;

namespace PetApi.Application.Queries
{
    public record GetPetByIdQuery(Guid Id) : IRequest<Pet>;
}