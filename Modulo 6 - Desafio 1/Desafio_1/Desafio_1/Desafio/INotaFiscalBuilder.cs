using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    public interface INotaFiscalBuilder
    {
        INotaFiscalBuilder ComRazaoSocial(string razaoSocial);
        INotaFiscalBuilder ComCnpj(string cnpj);
        INotaFiscalBuilder ComValorBruto(double valorBruto);
        INotaFiscalBuilder ComImpostos(double impostos);
        INotaFiscalBuilder NaData(DateTime dataEmissao);
        INotaFiscalBuilder ComObservacoes(string observacoes);
        INotaFiscalBuilder ComItem(ItemDaNota item);
        NotaFiscal Build();
    }
}
