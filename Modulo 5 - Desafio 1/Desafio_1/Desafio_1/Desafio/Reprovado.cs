using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    // Estado do orçamento: REPROVADO
    public class Reprovado : IState
    {
        public decimal AplicarDescontoExtra(Orcamento orcamento)
        {
            return 0;
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamento reprovado não pode ser aprovado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamento já está reprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }
    }
}
