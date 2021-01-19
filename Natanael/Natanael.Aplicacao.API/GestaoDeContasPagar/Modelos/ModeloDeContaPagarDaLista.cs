using Natanael.Dominio.ContasPagar;
using System;

namespace Natanael.Aplicacao.API.GestaoDeContasPagar.Modelos
{
    public class ModeloDeContaPagarDaLista
    {
        public ModeloDeContaPagarDaLista()
        {

        }

        public ModeloDeContaPagarDaLista(ContaPagar contaPagar) : this()
        {
            if (contaPagar == null)
                return;

            this.Nome = contaPagar.Nome;
            this.Valor = contaPagar.Valor.ToString("C");
            this.ValorCorrigido = contaPagar.ValorCorrigido.ToString("C");
            this.QuantidadeDeDiasDeAtraso = contaPagar.QuantidadeDeDiasEmAtraso;
            this.DataDePagamento = contaPagar.DataDePagamento.ToShortDateString();
        }

        public string Nome { get; private set; }
        public string Valor { get; private set; }
        public string ValorCorrigido { get; private set; }
        public int QuantidadeDeDiasDeAtraso { get; private set; }
        public string DataDePagamento { get; private set; }
    }
}