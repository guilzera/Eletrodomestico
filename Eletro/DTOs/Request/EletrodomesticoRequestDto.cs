using System.ComponentModel.DataAnnotations;

namespace Eletro.DTOs.Request
{
    public class EletrodomesticoRequestDto
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Marca { get; set; } = string.Empty;

        [StringLength(20)]
        public string Modelo { get; set; } = string.Empty;

        [StringLength(20)]
        public string NumeroSerie { get; set; } = string.Empty;

        [Required]
        public int ClienteId { get; set; }
    }
}
