using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    public class ProcessadorCSV : IProcessador
    {
        public void Processar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine($"{conta.Titular};{conta.Saldo}");
            }
        }
    }
}
