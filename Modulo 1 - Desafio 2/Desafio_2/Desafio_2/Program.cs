using Desafio_2.Desafio_2;

public class Program
{
    public static void Main()
    {
        ContaBancaria conta = new ContaBancaria(1000.00);

        IInvestimento conservador = new Conservador();
        IInvestimento moderado = new Moderado();
        IInvestimento arrojado = new Arrojado();

        RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos(conservador);
        realizador.Investir(conta, 500.00);
        Console.WriteLine($"Saldo após investimento conservador: R$ {conta.Saldo:F2}");

        realizador = new RealizadorDeInvestimentos(moderado);
        realizador.Investir(conta, 300.00);
        Console.WriteLine($"Saldo após investimento moderado: R$ {conta.Saldo:F2}");

        realizador = new RealizadorDeInvestimentos(arrojado);
        realizador.Investir(conta, 200.00);
        Console.WriteLine($"Saldo após investimento arrojado: R$ {conta.Saldo:F2}");
    }
}