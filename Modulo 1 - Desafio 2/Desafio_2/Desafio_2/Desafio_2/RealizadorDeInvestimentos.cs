using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    public class RealizadorDeInvestimentos
    {
        private IInvestimento _investimento;

        public RealizadorDeInvestimentos(IInvestimento investimento)
        {
            _investimento = investimento;
        }

        public void Investir(ContaBancaria conta, double valorInvestido)
        {
            double retornoInvestimento = _investimento.CalcularRetorno(valorInvestido);
            double lucroLiquido = retornoInvestimento * 0.75; // 75% do retorno é lucro líquido (após 25% de imposto)
            conta.AdicionarSaldo(lucroLiquido);
        }
    }
}
