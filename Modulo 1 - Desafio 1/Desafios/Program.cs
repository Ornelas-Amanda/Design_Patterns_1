using Desafio_1.Modulo_1;

public class Program
{
    public static void Main()
    {
        Orcamento orcamento1 = new Orcamento(800.00m);
        Orcamento orcamento2 = new Orcamento(2000.00m);
        Orcamento orcamento3 = new Orcamento(3500.00m);

        IImposto icms = new ICMS();
        IImposto iss = new ISS();
        IImposto iccc = new ICCC();

        CalculadorDeImposto calculadorICMS = new CalculadorDeImposto(icms);
        CalculadorDeImposto calculadorISS = new CalculadorDeImposto(iss);
        CalculadorDeImposto calculadorICCC = new CalculadorDeImposto(iccc);

        calculadorICMS.CalcularImposto(orcamento1); // Output: Valor do Imposto: R$ 90.00
        calculadorISS.CalcularImposto(orcamento2); // Output: Valor do Imposto: R$ 120.00
        calculadorICCC.CalcularImposto(orcamento3); // Output: Valor do Imposto: R$ 310.00
    }
}
