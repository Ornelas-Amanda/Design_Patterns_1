using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
   public class Servidor
    {
        private IProcessador processadorXML = new ProcessadorXML();
        private IProcessador processadorCSV = new ProcessadorCSV();
        private IProcessador processadorPorcento = new ProcessadorPorcento();

        public void ProcessarRequisicao(Requisicao requisicao, Conta conta)
        {
            processadorXML.Processar(requisicao, conta);
            processadorCSV.Processar(requisicao, conta);
            processadorPorcento.Processar(requisicao, conta);
        }
    }
}
