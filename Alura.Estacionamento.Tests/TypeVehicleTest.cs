using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Tests;

public class TypeVehicleTest
{

    [Fact]
    public void Check_Type_Vehicle()
    {
        // Arrange
        Veiculo vehicleOne = new();
        Veiculo vehicleTwo = new();

        var automovelType = (TipoVeiculo)0;
        var motocycleType = (TipoVeiculo)1;

        // Act
        vehicleOne.Tipo = automovelType;
        vehicleTwo.Tipo = motocycleType;

        // Assert
        Assert.Equal(TipoVeiculo.Motocicleta, vehicleTwo.Tipo);
        Assert.Equal(TipoVeiculo.Automovel, vehicleOne.Tipo);
    }

    [Fact]
    public void Vehicle_Type_MustBe_MotorcycleForOption1()
    {
        // Arrange
        Veiculo vehicle = new()
        {
            // Act
            Tipo = (TipoVeiculo)1
        };

        // Assert
        Assert.Equal(TipoVeiculo.Motocicleta, vehicle.Tipo);
    }
}