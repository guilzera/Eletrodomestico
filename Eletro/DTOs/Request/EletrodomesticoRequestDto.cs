using System.ComponentModel.DataAnnotations;

namespace Eletro.DTOs.Request
{
    public class EletrodomesticoRequestDto
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A marca é obrigatória")]
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
