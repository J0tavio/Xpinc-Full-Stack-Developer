using App.Class;

namespace Tests;

public class CalculadoraTest
{
    private Calculadora calc;

    public CalculadoraTest()
    {
        calc = new Calculadora("19/09/2024");
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(5, 4, 9)]
    public void TestSomar(int n1, int n2, int n3)
    {
        // Act
        int resultado = calc.Somar(n1, n2);

        // Assert
        Assert.Equal(n3, resultado);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(5, 4, 1)]
    public void TestSubtrair(int n1, int n2, int n3)
    {
        // Act
        int resultado = calc.Subtrair(n1, n2);

        // Assert
        Assert.Equal(n3, resultado);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(5, 4, 20)]
    public void TestMultiplicar(int n1, int n2, int n3)
    {
        // Act
        int resultado = calc.Multiplicar(n1, n2);

        // Assert
        Assert.Equal(n3, resultado);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(20, 4, 5)]
    public void TestDividir(int n1, int n2, int n3)
    {
        // Act
        int resultado = calc.Dividir(n1, n2);

        // Assert
        Assert.Equal(n3, resultado);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        calc.Somar(1, 2);
        calc.Somar(4, 5);
        calc.Somar(8, 7);
        calc.Somar(6, 3);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}