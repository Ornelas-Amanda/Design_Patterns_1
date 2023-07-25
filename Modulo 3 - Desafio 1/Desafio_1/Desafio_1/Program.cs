using System;

public interface IImposto
{
    decimal Calcular(Orcamento orcamento);
}

public abstract class ImpostoDecorator : IImposto
{
    protected IImposto _proximoImposto;

    public ImpostoDecorator(IImposto proximoImposto)
    {
        _proximoImposto = proximoImposto;
    }

    public abstract decimal Calcular(Orcamento orcamento);
}

public class ISS : IImposto
{
    public decimal Calcular(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06M;
    }
}

public class ICMS : IImposto
{
    public decimal Calcular(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1M + 50.0M;
    }
}

public class ICPP : ImpostoDecorator
{
    public ICPP(IImposto proximoImposto) : base(proximoImposto) { }

    public override decimal Calcular(Orcamento orcamento)
    {
        if (orcamento.Valor < 500.0M)
            return orcamento.Valor * 0.05M;

        return orcamento.Valor * 0.07M + (_proximoImposto == null ? 0 : _proximoImposto.Calcular(orcamento));
    }
}

public class IKCV : ImpostoDecorator
{
    public IKCV(IImposto proximoImposto) : base(proximoImposto) { }

    public override decimal Calcular(Orcamento orcamento)
    {
        if (orcamento.Valor > 500.0M && temItemComValorMaiorQue100(orcamento))
            return orcamento.Valor * 0.10M;

        return orcamento.Valor * 0.06M + (_proximoImposto == null ? 0 : _proximoImposto.Calcular(orcamento));
    }

    private bool temItemComValorMaiorQue100(Orcamento orcamento)
    {
        foreach (Item item in orcamento.Itens)
        {
            if (item.Valor > 100.0M)
                return true;
        }
        return false;
    }
}

public class Orcamento
{
    public decimal Valor { get; private set; }
    public List<Item> Itens { get; private set; }

    public Orcamento(decimal valor)
    {
        Valor = valor;
        Itens = new List<Item>();
    }

    public void AdicionarItem(Item item)
    {
        Itens.Add(item);
    }
}

public class Item
{
    public string Nome { get; private set; }
    public decimal Valor { get; private set; }

    public Item(string nome, decimal valor)
    {
        Nome = nome;
        Valor = valor;
    }
}

class Program
{
    static void Main()
    {
        Orcamento orcamento = new Orcamento(600.0M);
        orcamento.AdicionarItem(new Item("Caneta", 20.0M));
        orcamento.AdicionarItem(new Item("Lápis", 10.0M));

        IImposto iss = new ISS();
        IImposto icms = new ICMS();
        IImposto ikcv = new IKCV(null); // Não há próximo imposto para IKCV
        IImposto icpp = new ICPP(ikcv); // ICPP decorando IKCV

        // Composição de impostos: ISS e ICPP (que por sua vez decora IKCV)
        decimal valorTotalImpostos = iss.Calcular(orcamento) + icpp.Calcular(orcamento);

        Console.WriteLine("Valor total de impostos a serem pagos: R$" + valorTotalImpostos);
    }
}
