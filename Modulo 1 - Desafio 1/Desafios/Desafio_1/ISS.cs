using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Modulo_1
{
    public class ISS : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06m;
        }
    }
}
