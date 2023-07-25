using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{

    // Estado do orçamento: FINALIZADO
    public class Finalizado : IState
    {
        public decimal AplicarDescontoExtra(Orcamento orcamento)
        {
            return 0;
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamento finalizado não pode ser aprovado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamento finalizado não pode ser reprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamento já está finalizado.");
        }
    }
}
