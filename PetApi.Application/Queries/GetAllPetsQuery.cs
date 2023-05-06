using MediatR;
using PetApi.Domain;
using System.Collections.Generic;

namespace PetApi.Application.Queries
{
    public record GetAllPetsQuery() : IRequest<List<Pet>>;
}