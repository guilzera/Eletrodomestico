using Eletro.Data;
using Eletro.Models;
using Microsoft.EntityFrameworkCore;

namespace Eletro.Repositories.Implementations
{
    public class EletrodomesticoRepository : IEletrodomesticoRepository
    {
        private readonly AppDbContext _context;

        public EletrodomesticoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Eletrodomestico>> GetAllAsync()
            => await _context.Eletrodomesticos.ToListAsync();

        public async Task<Eletrodomestico?> GetByIdAsync(int id)
            => await _context.Eletrodomesticos.FindAsync(id).AsTask();

        public async Task CreateAsync(Eletrodomestico eletrodomestico)
        {
            _context.Eletrodomesticos.Add(eletrodomestico);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Eletrodomestico eletrodomestico)
        {
            _context.Eletrodomesticos.Update(eletrodomestico);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var eletrodomestico = _context.Eletrodomesticos.Find(id);
            if (eletrodomestico != null)
            {
                _context.Eletrodomesticos.Remove(eletrodomestico);
                await _context.SaveChangesAsync();
            }
        }
    }
}
