namespace PetVacSystem.Application.DTOs
{
    public class UserCreateDto
    {
        public string Nome { get; set; } = default!;
        public string Email { get; set; } = default!;
        public int Tel { get; set; }
        public string password { get; set; } = default!;

    }

    public class UserResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = default!;
        public string Email { get; set; } = default!;

    }
}