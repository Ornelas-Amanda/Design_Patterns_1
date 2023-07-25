using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Modulo_1
{
    public class ICMS : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05m + 50.00m;
        }
    }
}
