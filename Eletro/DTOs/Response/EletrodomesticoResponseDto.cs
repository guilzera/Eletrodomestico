namespace Eletro.DTOs.Response
{
    public class EletrodomesticoResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string NumeroSerie { get; set; } = string.Empty;

        public int ClienteId { get; set; }

        public ClienteResponseDto? Cliente { get; set; }

    }
}
