using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Modulo_1
{
    public class ICCC : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000.00m)
            {
                return orcamento.Valor * 0.05m;
            }
            else if (orcamento.Valor >= 1000.00m && orcamento.Valor <= 3000.00m)
            {
                return orcamento.Valor * 0.07m;
            }
            else
            {
                return orcamento.Valor * 0.08m + 30.00m;
            }
        }
    }
}
