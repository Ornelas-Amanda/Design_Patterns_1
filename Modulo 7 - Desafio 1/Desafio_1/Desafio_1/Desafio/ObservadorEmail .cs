using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    public class ObservadorEmail : INotaFiscalObserver
    {
        public void ExecutarAcao(NotaFiscal notaFiscal)
        {
            // Simula o envio do e-mail
            Console.WriteLine($"Enviando nota fiscal por e-mail: {notaFiscal.RazaoSocial} - Valor: {notaFiscal.ValorBruto}");
        }
    }

}
