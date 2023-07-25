using Desafio_1.Desafio;
using System;

public class Program
{
    public static void Main()
    {
        Orcamento orcamento = new Orcamento(1000.0M);

        // Testando o estado inicial do orçamento (EM APROVAÇÃO)
        orcamento.AplicarDescontoExtra();
        Console.WriteLine("Valor do orçamento após desconto extra: " + orcamento.Valor);

        // Aprova o orçamento
        orcamento.Aprovar();

        // Testando o estado após aprovação (APROVADO)
        orcamento.AplicarDescontoExtra();
        Console.WriteLine("Valor do orçamento após desconto extra: " + orcamento.Valor);

        // Finaliza o orçamento
        orcamento.Finalizar();

        // Tentando aplicar desconto após finalizar (não deve aplicar desconto)
        orcamento.AplicarDescontoExtra();
        Console.WriteLine("Valor do orçamento após desconto extra: " + orcamento.Valor);
    }
}
