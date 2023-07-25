using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    public class ProcessadorPorcento : IProcessador
    {
        public void Processar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                Console.WriteLine($"Titular: {conta.Titular}%Saldo: {conta.Saldo}%");
            }
        }
    }
}
