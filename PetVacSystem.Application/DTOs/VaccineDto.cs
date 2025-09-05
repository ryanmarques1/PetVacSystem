namespace PetVacSystem.Application.DTOs
{
    public class VaccineCreateDto
    {
        public string Nome { get; set; } = default!;
        public string? DescricaoVacina { get; set; }
        public int NovaAplicacao { get; set; }
    }

    public class VaccineResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = default!;
        public string? DescriçãoVacina { get; set; }
        public int NovaAplicacao{ get; set; }
    }
}