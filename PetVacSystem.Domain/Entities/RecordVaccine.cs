namespace PetVacSystem.Domain.Entities
{
    public class RecordVaccine
    {
        public int Id { get; set; }

        public int PetId { get; set; }
        public Pet Pet { get; set; } = default!;
        
        public int VacinaId { get; set; }
        public Vaccine Vaccine { get; set; } = default!;

        public DateTime DataAplicacao { get; set; }
        public string NomeVet { get; set; } = default!;
    }
}