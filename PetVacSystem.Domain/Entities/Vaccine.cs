namespace PetVacSystem.Domain.Entities
{
    public class Vaccine
    {
        public int Id { get; set; }
        public string NomeVacina { get; set; } = default!;

        public string? DescricaoVacina { get; set; }

        public int NovaAplicacao { get; set; } //em meses

        public ICollection<RecordVaccine> RecordsVaccine { get; set; } = new List<RecordVaccine>();

    }
}