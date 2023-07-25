using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio
{
    public class ContaPositiva : IEstadoConta
    {
        public void Depositar(ContaBancaria conta, decimal valor)
        {
            // Depósito efetuado com 2% de desconto
            conta.Saldo += valor * 0.98M;
        }

        public void Sacar(ContaBancaria conta, decimal valor)
        {
            // Verifica se o saldo ficará negativo após o saque
            if (conta.Saldo - valor < 0)
            {
                throw new InvalidOperationException("Saldo insuficiente para sacar.");
            }

            conta.Saldo -= valor;

            // Verifica se o saldo mudou de estado
            if (conta.Saldo < 0)
            {
                conta.Estado = new ContaNegativa();
            }
        }
    }
}
