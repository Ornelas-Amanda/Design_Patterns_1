using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio
{
    public class ContaBancaria
    {
        public decimal Saldo { get; private set; }
        public IEstadoConta Estado { get; set; }

        public ContaBancaria()
        {
            // Inicia a conta com saldo negativo e o estado correspondente
            Saldo = 0.0M;
            Estado = new ContaNegativa();
        }

        public void Depositar(decimal valor)
        {
            Estado.Depositar(this, valor);
        }

        public void Sacar(decimal valor)
        {
            Estado.Sacar(this, valor);
        }
    }
}
