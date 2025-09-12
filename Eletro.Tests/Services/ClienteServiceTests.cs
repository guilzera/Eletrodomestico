using Eletro.DTOs.Request;
using Eletro.Models;
using Eletro.Repositories;
using Eletro.Services.Implementations;
using Moq;

namespace Eletro.Tests.Services
{
    public class ClienteServiceTests
    {
        [Fact]
        public async Task CriarClienteComSucesso()
        {
            var repositoryMock = new Mock<IClienteRepository>();
            var service = new ClienteService(repositoryMock.Object);

            var dto = new ClienteRequestDto
            {
                Nome = "Teste",
                Email = "teste@email.com",
                Telefone = "123456789",
                Endereco = "Rua Teste, 123"
            };

            var result = await service.CreateAsync(dto);

            Assert.NotNull(result);
            Assert.Equal("Teste", result.Nome); 
        }

        [Fact]
        public async Task BuscarClientePorId_DeveRetornarCliente()
        {
            var repositoryMock = new Mock<IClienteRepository>();
            repositoryMock.Setup(r => r.GetByIdAsync(1))
                          .ReturnsAsync(new Cliente { Id = 1, Nome = "Teste" });

            var service = new ClienteService(repositoryMock.Object);

            var result = await service.GetByIdAsync(1);

            Assert.NotNull(result);
            Assert.Equal("Teste", result.Nome);
        }

        [Fact]
        public async Task BuscarClientePorId_DeveRetornarNuloQuandoNaoEncontrado()
        {
            var repositoryMock = new Mock<IClienteRepository>();
            repositoryMock.Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                          .ReturnsAsync((Cliente?)null);

            var service = new ClienteService(repositoryMock.Object);

            var result = await service.GetByIdAsync(999);

            Assert.Null(result);
        }
    }
}
