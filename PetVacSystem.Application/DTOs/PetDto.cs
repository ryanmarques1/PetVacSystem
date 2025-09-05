namespace PetVacSystem.Application.DTOs
{
    public class PetCreateDto
    {
        public string Nome { get; set; } = default!;
        public string Raça { get; set; } = default!;
        public int DonoId { get; set; }
    }

    public class PetResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = default!;
        public string Raça { get; set; } = default!;
        public int DonoId { get; set; }
        public string NomeDono { get; set; } = default!;
    }
}