
using Desafio_2.Desafio_2;

public class Program
{
    static void Main()
    {
        IList<Conta> contas = new List<Conta>
        {
            new Conta(50.0M, new DateTime(2023, 6, 10)),
            new Conta(2000.0M, new DateTime(2023, 6, 20)),
            new Conta(800000.0M, new DateTime(2023, 6, 5)),
            new Conta(150.0M, new DateTime(2023, 5, 25))
        };

        Filtro filtroSaldoMenorQue100 = new FiltroSaldoMenorQue100();
        Filtro filtroSaldoMaiorQue500Mil = new FiltroSaldoMaiorQue500Mil();
        Filtro filtroDataAberturaMesCorrente = new FiltroDataAberturaMesCorrente();

        Filtro filtroComposto = new FiltroComposto(filtroSaldoMenorQue100);
        filtroComposto = new FiltroComposto(filtroSaldoMaiorQue500Mil);
        filtroComposto = new FiltroComposto(filtroDataAberturaMesCorrente);

        IList<Conta> contasFiltradas = filtroComposto.Filtra(contas);

        foreach (Conta conta in contasFiltradas)
        {
            Console.WriteLine($"Conta com saldo: {conta.Saldo}, Data de abertura: {conta.DataAbertura}");
        }
    }
}
