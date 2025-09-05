using Eletro.Models;

namespace Eletro.Services
{
    public interface IEletrodomesticoService
    {
        Task<IEnumerable<Eletrodomestico>> GetAllAsync();
        Task<Eletrodomestico?> GetByIdAsync(int id);
        Task CreateAsync(Eletrodomestico eletrodomestico);
        Task UpdateAsync(Eletrodomestico eletrodomestico);
        Task DeleteAsync(Eletrodomestico eletrodomestico);
    }
}
