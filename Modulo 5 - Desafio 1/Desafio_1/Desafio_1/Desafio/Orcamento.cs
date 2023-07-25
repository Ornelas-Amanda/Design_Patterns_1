using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    // Classe Orçamento com o estado atual e os métodos que interagem com o estado
    public class Orcamento
    {
        public decimal Valor { get; private set; }
        public IState Estado { get; set; }

        public Orcamento(decimal valor)
        {
            Valor = valor;
            Estado = new EmAprovacao();
        }

        public void AplicarDescontoExtra()
        {
            decimal descontoExtra = Estado.AplicarDescontoExtra(this);
            Valor -= descontoExtra;
        }

        public void Aprovar()
        {
            Estado.Aprovar(this);
        }

        public void Reprovar()
        {
            Estado.Reprovar(this);
        }

        public void Finalizar()
        {
            Estado.Finalizar(this);
        }
    }
}
