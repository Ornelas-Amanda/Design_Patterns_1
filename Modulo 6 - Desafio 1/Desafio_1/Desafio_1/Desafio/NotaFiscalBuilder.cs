﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Desafio
{
    public class NotaFiscalBuilder : INotaFiscalBuilder
    {
        private string razaoSocial;
        private string cnpj;
        private double valorBruto;
        private double impostos;
        private DateTime dataEmissao = DateTime.Now; // Valor padrão para a data de emissão
        private string observacoes;
        private List<ItemDaNota> itens;

        public NotaFiscalBuilder()
        {
            itens = new List<ItemDaNota>();
        }

        public INotaFiscalBuilder ComRazaoSocial(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
            return this;
        }

        public INotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.cnpj = cnpj;
            return this;
        }

        public INotaFiscalBuilder ComValorBruto(double valorBruto)
        {
            this.valorBruto = valorBruto;
            return this;
        }

        public INotaFiscalBuilder ComImpostos(double impostos)
        {
            this.impostos = impostos;
            return this;
        }

        public INotaFiscalBuilder NaData(DateTime dataEmissao)
        {
            this.dataEmissao = dataEmissao;
            return this;
        }

        public INotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.observacoes = observacoes;
            return this;
        }

        public INotaFiscalBuilder ComItem(ItemDaNota item)
        {
            itens.Add(item);
            return this;
        }

        public NotaFiscal Build()
        {
            return new NotaFiscal(razaoSocial, cnpj, valorBruto, impostos, dataEmissao, observacoes, itens);
        }
    }

}
