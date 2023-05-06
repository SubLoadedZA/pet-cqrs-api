namespace PetApi.Domain
{
    public class Pet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public DateTime BirthDate  { get; set; }
        
        public Pet(Guid id, string name, string species, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Species = species;
            BirthDate  = birthDate;
        }
    }
    
    
}