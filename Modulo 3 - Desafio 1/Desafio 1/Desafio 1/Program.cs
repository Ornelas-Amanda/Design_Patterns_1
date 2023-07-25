
using Desafio_1.Desafio;

public class Program
{
   public  static void Main()
    {
        Orcamento orcamento1 = new Orcamento(400.0);
        Orcamento orcamento2 = new Orcamento(600.0);

        ImpostoTemplate icpp = new ICPP();
        ImpostoTemplate ikcv = new IKCV();

        Console.WriteLine($"Imposto ICPP no orcamento1: {icpp.Calcular(orcamento1)}");
        Console.WriteLine($"Imposto ICPP no orcamento2: {icpp.Calcular(orcamento2)}");
        Console.WriteLine($"Imposto IKCV no orcamento1: {ikcv.Calcular(orcamento1)}");
        Console.WriteLine($"Imposto IKCV no orcamento2: {ikcv.Calcular(orcamento2)}");
    }
}