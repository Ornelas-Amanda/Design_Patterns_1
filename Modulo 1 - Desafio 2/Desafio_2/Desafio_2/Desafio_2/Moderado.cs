using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    public class Moderado : IInvestimento
    {
        public double CalcularRetorno(double valorInvestido)
        {
            bool escolhido = new Random().Next(101) > 50;
            return escolhido ? valorInvestido * 0.025 : valorInvestido * 0.007;
        }
    }
}
