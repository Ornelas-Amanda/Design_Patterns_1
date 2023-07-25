using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio_1
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double CalcularDesconto(Compra compra);
    }
}
