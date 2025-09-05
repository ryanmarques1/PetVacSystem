namespace PetVacSystem.Application.DTOs
{
    public class RecordVaccineCreateDto
    {
        public int PetId { get; set; }
        public int VacinaId { get; set; }
        public DateTime DataAplicacao { get; set; }
        public string NomeVet { get; set; } = default!;
    }

    public class RecordVaccineResponseDto
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public string NomePet { get; set; } = default!;
        public int VacinaId { get; set; }
        public string NomeVacina { get; set; } = default!;
        public DateTime DataAplicacao { get; set; }
        public string NomeVet { get; set; } = default!;
    }
}