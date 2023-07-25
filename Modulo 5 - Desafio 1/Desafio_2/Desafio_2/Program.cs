
using Desafio_2.Desafio;

public class Program
{
    public static void Main()
    {
        ContaBancaria conta = new ContaBancaria();

        Console.WriteLine("Saldo inicial: " + conta.Saldo);

        conta.Depositar(500.0M);
        Console.WriteLine("Saldo após depósito: " + conta.Saldo);

        conta.Sacar(200.0M);
        Console.WriteLine("Saldo após saque: " + conta.Saldo);

        conta.Depositar(300.0M);
        Console.WriteLine("Saldo após depósito: " + conta.Saldo);
    }
}
