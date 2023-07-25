using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    public class FiltroSaldoMaiorQue500Mil : Filtro
    {
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> contasFiltradas = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.Saldo > 500000.0M)
                    contasFiltradas.Add(conta);
            }
            return contasFiltradas;
        }
    }
}
