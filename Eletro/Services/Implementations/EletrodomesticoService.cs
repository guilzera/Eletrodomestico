using Eletro.DTOs.Request;
using Eletro.DTOs.Response;
using Eletro.Models;
using Eletro.Repositories;

namespace Eletro.Services.Implementations
{
    public class EletrodomesticoService : IEletrodomesticoService
    {
        private readonly IEletrodomesticoRepository _repository;

        public EletrodomesticoService(IEletrodomesticoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EletrodomesticoResponseDto>> GetAllAsync()
        {
            var eletros = await _repository.GetAllAsync();
            var response = new List<EletrodomesticoResponseDto>();

            foreach (var eletro in eletros)
            {
                response.Add(new EletrodomesticoResponseDto
                {
                    Id = eletro.Id,
                    Nome = eletro.Nome,
                    Marca = eletro.Marca,
                    Modelo = eletro.Modelo,
                    NumeroSerie = eletro.NumeroSerie,
                    ClienteId = eletro.ClienteId
                });
            }

            return response;
        }

        public async Task<EletrodomesticoResponseDto?> GetByIdAsync(int id)
        {
            var eletro = await _repository.GetByIdAsync(id);
            if (eletro == null) return null;

            return new EletrodomesticoResponseDto
            {
                Id = eletro.Id,
                Nome = eletro.Nome,
                Marca = eletro.Marca,
                Modelo = eletro.Modelo,
                NumeroSerie = eletro.NumeroSerie,
                ClienteId = eletro.ClienteId
            };
        }

        public async Task<EletrodomesticoResponseDto> CreateAsync(EletrodomesticoRequestDto dto)
        {
            var eletro = new Eletrodomestico
            {
                Nome = dto.Nome,
                Marca = dto.Marca,
                Modelo = dto.Modelo,
                NumeroSerie = dto.NumeroSerie,
                ClienteId = dto.ClienteId
            };

            await _repository.CreateAsync(eletro);

            return new EletrodomesticoResponseDto
            {
                Id = eletro.Id,
                Nome = eletro.Nome,
                Marca = eletro.Marca,
                Modelo = eletro.Modelo,
                NumeroSerie = eletro.NumeroSerie,
                ClienteId = eletro.ClienteId
            };
        }

        public async Task<EletrodomesticoResponseDto?> UpdateAsync(int id, EletrodomesticoRequestDto dto)
        {
            var eletro = await _repository.GetByIdAsync(id);
            if (eletro == null) return null;

            eletro.Nome = dto.Nome;
            eletro.Marca = dto.Marca;
            eletro.Modelo = dto.Modelo;
            eletro.NumeroSerie = dto.NumeroSerie;
            eletro.ClienteId = dto.ClienteId;

            await _repository.UpdateAsync(eletro);

            return new EletrodomesticoResponseDto
            {
                Id = eletro.Id,
                Nome = eletro.Nome,
                Marca = eletro.Marca,
                Modelo = eletro.Modelo,
                NumeroSerie = eletro.NumeroSerie,
                ClienteId = eletro.ClienteId
            };
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var eletro = await _repository.GetByIdAsync(id);
            if (eletro == null) return false;

            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
