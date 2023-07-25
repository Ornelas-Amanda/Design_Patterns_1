using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio
{
    // Interface representando os estados da conta bancária
    public interface IEstadoConta
    {
        void Depositar(ContaBancaria conta, decimal valor);
        void Sacar(ContaBancaria conta, decimal valor);
    }
}
