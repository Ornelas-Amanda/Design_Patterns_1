using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Desafio_2
{

    public class FiltroComposto : FiltroDecorator
    {
        public FiltroComposto(Filtro proximoFiltro) : base(proximoFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> contasFiltradas = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (_proximoFiltro.Filtra(contas).Contains(conta))
                    contasFiltradas.Add(conta);
            }
            return contasFiltradas;
        }
    }
}
