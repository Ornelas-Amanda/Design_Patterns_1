using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }

        public ContaBancaria(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void AdicionarSaldo(double valor)
        {
            Saldo += valor;
        }
    }
}
