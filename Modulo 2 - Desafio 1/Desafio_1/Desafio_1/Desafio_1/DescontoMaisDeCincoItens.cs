using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio_1
{
    public class DescontoMaisDeCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalcularDesconto(Compra compra)
        {
            if (compra.Itens.Length > 5)
                return compra.ValorTotal * 0.10;
            else if (Proximo != null)
                return Proximo.CalcularDesconto(compra);
            else
                return 0;
        }
    }
}
