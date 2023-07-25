using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio
{
    public class ContaNegativa : IEstadoConta
    {
        public void Depositar(ContaBancaria conta, decimal valor)
        {
            // Depósito efetuado com desconto de 5%
            conta.Saldo += valor * 0.95M;

            // Verifica se o saldo mudou de estado
            if (conta.Saldo >= 0)
            {
                conta.Estado = new ContaPositiva();
            }
        }

        public void Sacar(ContaBancaria conta, decimal valor)
        {
            throw new InvalidOperationException("Conta com saldo negativo não pode sacar.");
        }
    }
}
