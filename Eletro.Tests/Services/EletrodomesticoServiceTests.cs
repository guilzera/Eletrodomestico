using Eletro.DTOs.Request;
using Eletro.Repositories;
using Eletro.Services.Implementations;
using Moq;

namespace Eletro.Tests.Services
{
    public class EletrodomesticoServiceTests
    {
        [Fact]
        public async Task CriarEletrodomesticoComSucesso()
        {
            var repositoryMock = new Mock<IEletrodomesticoRepository>();
            var service = new EletrodomesticoService(repositoryMock.Object);

            var dto = new EletrodomesticoRequestDto
            {
                Nome = "Geladeira",
                Marca = "Brastemp",
                Modelo = "",
                NumeroSerie = "",
            };

            var result = await service.CreateAsync(dto);

            Assert.NotNull(result);
            Assert.Equal("Geladeira", result.Nome);
            Assert.Equal("Brastemp", result.Marca);

        }
    }
}
