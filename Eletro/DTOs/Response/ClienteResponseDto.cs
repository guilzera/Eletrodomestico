namespace Eletro.DTOs.Response
{
    public class ClienteResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;

        public List<EletrodomesticoResponseDto>? Eletrodomesticos { get; set; } = new();
    }
}
