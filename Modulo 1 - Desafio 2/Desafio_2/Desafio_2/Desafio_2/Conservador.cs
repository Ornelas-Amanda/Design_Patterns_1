using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    public class Conservador : IInvestimento
    {
        public double CalcularRetorno(double valorInvestido)
        {
            return valorInvestido * 0.008;
        }
    }
}
