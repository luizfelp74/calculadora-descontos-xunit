using CalculadoraDescontos.App;

namespace CalculadoraDescontos.Tests;

public class DescontoServiceTests
{
    private readonly DescontoService _service = new DescontoService();

    // Teste 1 (string)
    [Theory]
    [InlineData(2, "BRONZE")]
    [InlineData(7, "PRATA")]
    [InlineData(15, "OURO")]
    public void ObterCategoriaCliente_TotalDeCompras_RetornaCategoriaEsperada(int totalCompras, string esperado)
    {
        string resultado = _service.ObterCategoriaCliente(totalCompras);

        Assert.Equal(esperado, resultado);
    }

    // Teste 2 (int)
    [Theory]
    [InlineData(100, 10, 90)]
    [InlineData(200, 20, 160)]
    [InlineData(50, 0, 50)]
    public void CalcularDescontoPorPercentual_ValorEPercentual_RetornaValorFinal(int valorOriginal, int percentual, int esperado)
    {
        int resultado = _service.CalcularDescontoPorPercentual(valorOriginal, percentual);

        Assert.Equal(esperado, resultado);
    }

    // Teste 3 (bool)
    [Theory]
    [InlineData(20, false, true)]
    [InlineData(16, true, true)]
    [InlineData(17, false, false)]
    public void EValidoParaCupom_IdadeEPrimeiraCompra_RetornaElegibilidade(int idade, bool primeiraCompra, bool esperado)
    {
        bool resultado = _service.EValidoParaCupom(idade, primeiraCompra);

        Assert.Equal(esperado, resultado);
    }
}
