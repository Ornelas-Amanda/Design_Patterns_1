using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    public class Arrojado : IInvestimento
    {
        public double CalcularRetorno(double valorInvestido)
        {
            int chance = new Random().Next(101);
            if (chance <= 20)
            {
                return valorInvestido * 0.05;
            }
            else if (chance > 20 && chance <= 50)
            {
                return valorInvestido * 0.03;
            }
            else
            {
                return valorInvestido * 0.006;
            }
        }
    }
}
