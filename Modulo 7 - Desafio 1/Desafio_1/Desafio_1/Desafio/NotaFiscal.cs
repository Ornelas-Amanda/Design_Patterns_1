using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; }
        public string Cnpj { get; }
        public double ValorBruto { get; }
        public double Impostos { get; }
        public DateTime DataEmissao { get; }
        public string Observacoes { get; }
        public List<ItemDaNota> Itens { get; }

        public NotaFiscal(string razaoSocial, string cnpj, double valorBruto, double impostos,
                          DateTime dataEmissao, string observacoes, List<ItemDaNota> itens)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            ValorBruto = valorBruto;
            Impostos = impostos;
            DataEmissao = dataEmissao;
            Observacoes = observacoes;
            Itens = itens;
        }
    }
}
