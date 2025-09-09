using Eletro.DTOs.Request;
using Eletro.DTOs.Response;

namespace Eletro.Services
{
    public interface IEletrodomesticoService
    {
        Task<IEnumerable<EletrodomesticoResponseDto>> GetAllAsync();
        Task<EletrodomesticoResponseDto?> GetByIdAsync(int id);
        Task<EletrodomesticoResponseDto> CreateAsync(EletrodomesticoRequestDto dto);
        Task<EletrodomesticoResponseDto?> UpdateAsync(int id, EletrodomesticoRequestDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
