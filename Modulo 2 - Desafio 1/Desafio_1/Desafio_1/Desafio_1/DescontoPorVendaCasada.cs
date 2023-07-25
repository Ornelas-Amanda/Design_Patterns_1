using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio_1
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalcularDesconto(Compra compra)
        {
            bool temLapisECaneta = Existe("LAPIS", compra) && Existe("CANETA", compra);

            if (temLapisECaneta)
                return compra.ValorTotal * 0.05;
            else if (Proximo != null)
                return Proximo.CalcularDesconto(compra);
            else
                return 0;
        }

        private bool Existe(string nomeDoItem, Compra compra)
        {
            foreach (var item in compra.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }

}
