using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetApi.Application.Commands;
using PetApi.Application.Queries;
using PetApi.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PetsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Pet>> Get()
        {
            return await _mediator.Send(new GetAllPetsQuery());
        }

        [HttpGet("{id}")]
        public async Task<Pet> Get(Guid id)
        {
            return await _mediator.Send(new GetPetByIdQuery(id));
        }

        [HttpPost]
        public async Task<Pet> Post([FromBody] CreatePetCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<Unit> Put(Guid id, [FromBody] UpdatePetCommand command)
        {
            if (id != command.Id)
            {
                throw new ArgumentException("ID in URL and body don't match");
            }

            return await _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<Unit> Delete(Guid id)
        {
            return await _mediator.Send(new DeletePetCommand(id));
        }
    }
}