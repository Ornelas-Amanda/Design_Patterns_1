using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    // Estado inicial do orçamento: EM APROVAÇÃO
    public class EmAprovacao : IState
    {
        public bool DescontoAplicado { get; private set; } = false;
        public decimal AplicarDescontoExtra(Orcamento orcamento)
        {
            if (!DescontoAplicado)
            {
                DescontoAplicado = true;
                return orcamento.Valor * 0.05M;
            }
            else
            {
                throw new InvalidOperationException("Desconto extra já foi aplicado.");
            }
        }
        public void Aprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamento em aprovação não pode ser finalizado diretamente.");
        }
    }
}
