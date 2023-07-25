using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    interface IProcessador
    {
        void Processar(Requisicao requisicao, Conta conta);
    }
}
