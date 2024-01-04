using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Tests;

public class GarthTest
{
    private readonly Patio? _garth;
    private readonly Veiculo _vehicle = new()
    {
        Proprietario = "Italo Rayone",
        Tipo = TipoVeiculo.Automovel,
        Cor = "CINZA",
        Placa = "JGG-9803"
    };

    [Fact]
    public void Validate_Billing()
    {
        // Arrange
        _garth!.RegistrarEntradaVeiculo(_vehicle);
        _garth!.RegistrarSaidaVeiculo(_vehicle.Placa);

        // Act
        double billing = _garth.TotalFaturado();

        // Assert
        Assert.Equal(2, billing);
    }
}