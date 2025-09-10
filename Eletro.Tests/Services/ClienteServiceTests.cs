using Eletro.DTOs.Request;
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
    }
}
