using Eletro.DTOs.Request;
using Eletro.DTOs.Response;
using Eletro.Models;

namespace Eletro.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteResponseDto>> GetAllAsync();
        Task<ClienteResponseDto?> GetByIdAsync(int id);
        Task<ClienteResponseDto> CreateAsync(ClienteRequestDto dto);
        Task<ClienteResponseDto> UpdateAsync(int id, ClienteRequestDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
