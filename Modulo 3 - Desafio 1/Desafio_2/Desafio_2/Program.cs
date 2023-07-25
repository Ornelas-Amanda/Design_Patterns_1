using System;
using System.Collections.Generic;

abstract class RelatorioTemplate
{
    protected abstract string Cabecalho();
    protected abstract string Corpo(IList<Conta> contas);
    protected abstract string Rodape();

    public string GerarRelatorio(IList<Conta> contas)
    {
        string relatorio = Cabecalho();
        relatorio += Corpo(contas);
        relatorio += Rodape();
        return relatorio;
    }
}

class RelatorioSimples : RelatorioTemplate
{
    protected override string Cabecalho()
    {
        return "Banco XYZ - Telefone: (11) 1234-5678\n";
    }

    protected override string Corpo(IList<Conta> contas)
    {
        string corpo = "Relatório de Contas:\n";
        foreach (var conta in contas)
        {
            corpo += $"Titular: {conta.Titular}, Saldo: R${conta.Saldo}\n";
        }
        return corpo;
    }

    protected override string Rodape()
    {
        return "";
    }
}

class RelatorioComplexo : RelatorioTemplate
{
    protected override string Cabecalho()
    {
        return "Banco XYZ - Endereço: Rua ABC, 123 - Telefone: (11) 1234-5678\n";
    }

    protected override string Corpo(IList<Conta> contas)
    {
        string corpo = "Relatório de Contas:\n";
        foreach (var conta in contas)
        {
            corpo += $"Titular: {conta.Titular}, Agência: {conta.Agencia}, Número da Conta: {conta.Numero}, Saldo: R${conta.Saldo}\n";
        }
        return corpo;
    }

    protected override string Rodape()
    {
        return $"E-mail: contato@bancoxyz.com - Data: {DateTime.Now.ToShortDateString()}\n";
    }
}

class Conta
{
    public string Titular { get; set; }
    public string Agencia { get; set; }
    public string Numero { get; set; }
    public decimal Saldo { get; set; }
}

class Program
{
    static void Main()
    {
        IList<Conta> contas = new List<Conta>
        {
            new Conta { Titular = "João", Agencia = "001", Numero = "12345", Saldo = 1500.00M },
            new Conta { Titular = "Maria", Agencia = "002", Numero = "54321", Saldo = 2500.50M }
        };

        RelatorioTemplate relatorioSimples = new RelatorioSimples();
        RelatorioTemplate relatorioComplexo = new RelatorioComplexo();

        Console.WriteLine("Relatório Simples:\n" + relatorioSimples.GerarRelatorio(contas));
        Console.WriteLine("\nRelatório Complexo:\n" + relatorioComplexo.GerarRelatorio(contas));
    }
}
