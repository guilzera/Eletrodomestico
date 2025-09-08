using Eletro.DTOs.Request;
using Eletro.DTOs.Response;
using Eletro.Models;
using Eletro.Repositories;

namespace Eletro.Services.Implementations
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        } 

        public async Task<IEnumerable<ClienteResponseDto>> GetAllAsync()
        {
            var clientes = await _repository.GetAllAsync();

            return clientes.Select(x => new ClienteResponseDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Email = x.Email,
                Telefone = x.Telefone,
                Endereco = x.Endereco
            });
        }

        public async Task<ClienteResponseDto?> GetByIdAsync(int id)
        {
            var cliente = await _repository.GetByIdAsync(id);
            if (cliente == null) return null;

            return new ClienteResponseDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Email = cliente.Email,
                Telefone = cliente.Telefone,
                Endereco = cliente.Endereco
            };
        }

        public async Task<ClienteResponseDto> CreateAsync(ClienteRequestDto dto)
        {
            var cliente = new Cliente
            {
                Nome = dto.Nome,
                Email = dto.Email,
                Telefone = dto.Telefone,
                Endereco = dto.Endereco
            };
            await _repository.CreateAsync(cliente);

           return new ClienteResponseDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Email = cliente.Email,
                Telefone = cliente.Telefone,
                Endereco = cliente.Endereco
            };
        }

        public async Task<ClienteResponseDto> UpdateAsync(int id, ClienteRequestDto dto)
        {
            var cliente = await _repository.GetByIdAsync(id);
            if (cliente == null) return null;

            cliente.Nome = dto.Nome;
            cliente.Email = dto.Email;
            cliente.Telefone = dto.Telefone;
            cliente.Endereco = dto.Endereco;

            await _repository.UpdateAsync(cliente);

            return new ClienteResponseDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Email = cliente.Email,
                Telefone = cliente.Telefone,
                Endereco = cliente.Endereco
            };
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var cliente = _repository.GetByIdAsync(id);
            if (cliente == null) return false;

            await _repository.DeleteAsync(id);
            return true;
        }
    }
}