using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{
    public abstract class FiltroDecorator : Filtro
    {
        protected Filtro _proximoFiltro;

        public FiltroDecorator(Filtro proximoFiltro)
        {
            _proximoFiltro = proximoFiltro;
        }
    }
}
