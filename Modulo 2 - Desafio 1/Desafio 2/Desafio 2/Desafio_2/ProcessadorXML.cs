using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
   public class ProcessadorXML : IProcessador
    {
        public void Processar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.XML)
            {
                Console.WriteLine($"<Conta><Titular>{conta.Titular}</Titular><Saldo>{conta.Saldo}</Saldo></Conta>");
            }
        }
    }
}
