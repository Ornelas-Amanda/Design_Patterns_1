using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    public class Conta
    {
        public decimal Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }

        public Conta(decimal saldo, DateTime dataAbertura)
        {
            Saldo = saldo;
            DataAbertura = dataAbertura;
        }
    }
}
