using PetApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetApi.Infrastructure
{
    public class PetDataStore
    {
        private readonly List<Pet> _pets = new List<Pet>();

        public Pet AddPet(Pet pet)
        {
            _pets.Add(pet);
            return pet;
        }

        public Pet GetPetById(Guid id)
        {
            return _pets.FirstOrDefault(p => p.Id == id);
        }

        public List<Pet> GetAllPets()
        {
            return _pets;
        }

        public void UpdatePet(Pet pet)
        {
            var existingPet = GetPetById(pet.Id);
            if (existingPet != null)
            {
                existingPet.Name = pet.Name;
                existingPet.Species = pet.Species;
                existingPet.BirthDate = pet.BirthDate;
            }
        }

        public void DeletePet(Guid id)
        {
            var pet = GetPetById(id);
            if (pet != null)
            {
                _pets.Remove(pet);
            }
        }
    }
}
