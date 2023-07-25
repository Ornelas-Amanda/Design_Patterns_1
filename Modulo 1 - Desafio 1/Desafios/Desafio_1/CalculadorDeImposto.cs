using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Modulo_1
{
    public class CalculadorDeImposto
    {
        private IImposto _imposto;

        public CalculadorDeImposto(IImposto imposto)
        {
            _imposto = imposto;
        }

        public void CalcularImposto(Orcamento orcamento)
        {
            decimal valorImposto = _imposto.Calcular(orcamento);
            Console.WriteLine($"Valor do Imposto: R$ {valorImposto:F2}");
        }
    }
}
