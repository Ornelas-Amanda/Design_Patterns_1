using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    public class IHIT : ImpostoTemplate
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            HashSet<string> nomes = new HashSet<string>();
            foreach (var item in orcamento.Itens)
            {
                if (nomes.Contains(item.Nome))
                    return true;
                nomes.Add(item.Nome);
            }
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100.0;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens.Count * 0.01;
        }
    }
}
