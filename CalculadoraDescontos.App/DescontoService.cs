namespace CalculadoraDescontos.App;

public class DescontoService
{
    // Retorno string: categoria do cliente conforme o total de compras.
    // < 5 -> BRONZE | 5 a 10 (inclusive) -> PRATA | > 10 -> OURO
    public string ObterCategoriaCliente(int totalCompras)
    {
        if (totalCompras < 5)
        {
            return "BRONZE";
        }

        if (totalCompras <= 10)
        {
            return "PRATA";
        }

        return "OURO";
    }

    // Retorno int: valor final com o desconto aplicado.
    // Ex.: (100, 10) -> 90
    public int CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto)
    {
        int desconto = valorOriginal * percentualDesconto / 100;
        return valorOriginal - desconto;
    }

    // Retorno bool: true se idade >= 18 OU for a primeira compra.
    public bool EValidoParaCupom(int idade, bool primeiraCompra)
    {
        return idade >= 18 || primeiraCompra;
    }
}
