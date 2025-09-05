namespace PetVacSystem.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Tel { get; set; } = default!;
        public string password { get; set; }

        public ICollection<Pet> Pets { get; set; } = new List<Pet>(); 
    }
}