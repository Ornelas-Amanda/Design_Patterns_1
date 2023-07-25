using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    public class ItemDaNota
    {
        public string Descricao { get; }
        public double Valor { get; }

        public ItemDaNota(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}
