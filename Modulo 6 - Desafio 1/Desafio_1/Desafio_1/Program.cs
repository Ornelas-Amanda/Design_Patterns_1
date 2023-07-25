
using Desafio_1.Desafio;

public class Program
{
    public static void Main()
    {
        INotaFiscalBuilder builder = new NotaFiscalBuilder();
        NotaFiscal notaFiscal = builder
            .ComRazaoSocial("Empresa XYZ")
            .ComCnpj("12.345.678/0001-90")
            .ComValorBruto(1500.0)
            .ComImpostos(200.0)
            .NaData(new DateTime(2023, 6, 30)) 
            .ComObservacoes("Nota fiscal de venda")
            .ComItem(new ItemDaNota("Item 1", 500.0))
            .ComItem(new ItemDaNota("Item 2", 400.0))
            .ComItem(new ItemDaNota("Item 3", 600.0))
            .Build();

        Console.WriteLine("Nota Fiscal Emitida:");
        Console.WriteLine($"Razão Social: {notaFiscal.RazaoSocial}");
        Console.WriteLine($"CNPJ: {notaFiscal.Cnpj}");
        Console.WriteLine($"Valor Bruto: {notaFiscal.ValorBruto}");
        Console.WriteLine($"Impostos: {notaFiscal.Impostos}");
        Console.WriteLine($"Data de Emissão: {notaFiscal.DataEmissao}");
        Console.WriteLine($"Observações: {notaFiscal.Observacoes}");
        Console.WriteLine("Itens:");
        foreach (var item in notaFiscal.Itens)
        {
            Console.WriteLine($"- {item.Descricao}: {item.Valor}");
        }
    }
}
