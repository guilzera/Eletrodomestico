using Eletro.Models;

namespace Eletro.Repositories
{
    public interface IEletrodomesticoRepository
    {
        Task<IEnumerable<Eletrodomestico>> GetAllAsync();
        Task<Eletrodomestico?> GetByIdAsync(int id);
        Task CreateAsync(Eletrodomestico eletrodomestico);
        Task UpdateAsync(Eletrodomestico eletrodomestico);
        Task DeleteAsync(int id);
    }
}
