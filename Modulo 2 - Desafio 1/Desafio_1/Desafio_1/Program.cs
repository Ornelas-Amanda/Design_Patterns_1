using Desafio_1.Desafio_1;

public class Program
{
    public static void Main()
    {
        //Compra compra1 = new Compra { Itens = 3, ValorTotal = 300.00 };
        //Compra compra2 = new Compra { Itens = 10, ValorTotal = 800.00 };

        //IDesconto descontoMaisDeCincoItens = new DescontoMaisDeCincoItens();
        //IDesconto descontoValorMaiorQueQuinhentos = new DescontoValorMaiorQueQuinhentos();

        //descontoMaisDeCincoItens.Proximo = descontoValorMaiorQueQuinhentos;

        //double desconto1 = descontoMaisDeCincoItens.CalcularDesconto(compra1);
        //double desconto2 = descontoMaisDeCincoItens.CalcularDesconto(compra2);

        //Console.WriteLine($"Desconto para a compra 1: R$ {desconto1:F2}");
        //Console.WriteLine($"Desconto para a compra 2: R$ {desconto2:F2}");
        Compra compra1 = new Compra
        {
            Itens = new Item[] {
                new Item { Nome = "LAPIS", Valor = 1.00 },
                new Item { Nome = "CANETA", Valor = 2.00 }
            },
            ValorTotal = 3.00
        };

        IDesconto descontoMaisDeCincoItens = new DescontoMaisDeCincoItens();
        IDesconto descontoValorMaiorQueQuinhentos = new DescontoValorMaiorQueQuinhentos();
        IDesconto descontoPorVendaCasada = new DescontoPorVendaCasada();

        descontoMaisDeCincoItens.Proximo = descontoValorMaiorQueQuinhentos;
        descontoValorMaiorQueQuinhentos.Proximo = descontoPorVendaCasada;

        double desconto1 = descontoMaisDeCincoItens.CalcularDesconto(compra1);

        Console.WriteLine($"Desconto para a compra 1: R$ {desconto1:F2}");
    }
}