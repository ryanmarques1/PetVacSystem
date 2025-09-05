namespace PetVacSystem.Domain.Entities
{
    public class Pet
    {
        public int Id { get; set; }
        public string NomePet { get; set; } = default!;
        public string Raca { get; set; } = default!;

        public int DonoId { get; set; }

        public User Dono { get; set; } = default!;

        public ICollection<RecordVaccine> RecordsVaccine { get; set; } = new List<RecordVaccine>();

    }
}