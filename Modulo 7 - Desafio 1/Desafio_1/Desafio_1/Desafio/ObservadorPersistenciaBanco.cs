using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    public class ObservadorPersistenciaBanco : INotaFiscalObserver
    {
        public void ExecutarAcao(NotaFiscal notaFiscal)
        {
            // Simula a persistência no banco de dados
            Console.WriteLine($"Persistindo nota fiscal no banco de dados: {notaFiscal.RazaoSocial} - Valor: {notaFiscal.ValorBruto}");
        }
    }

}
