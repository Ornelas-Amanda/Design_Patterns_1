using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    // Estado do orçamento: APROVADO
    public class Aprovado : IState
    {
        public bool DescontoAplicado { get; private set; } = false;

        public decimal AplicarDescontoExtra(Orcamento orcamento)
        {
            if (!DescontoAplicado)
            {
                DescontoAplicado = true;
                return orcamento.Valor * 0.02M;
            }
            else
            {
                throw new InvalidOperationException("Desconto extra já foi aplicado.");
            }
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamento já está aprovado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamento aprovado não pode ser reprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }
    }
}
