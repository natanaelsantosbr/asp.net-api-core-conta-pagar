using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.API.GestaoDeContasPagar.Modelos
{
    public class ModeloDeCadastroDeContaPagar
    {
        public ModeloDeCadastroDeContaPagar()
        {

        }
        
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string DataDeVencimento { get; set; }
        public string DataDePagamento { get; set; }

        public double ValorFormatado => !string.IsNullOrEmpty(this.Valor) ? double.Parse(this.Valor) : 0;

        public DateTime DataDeVencimentoFormatada => !string.IsNullOrEmpty(this.DataDeVencimento) ? DateTime.Parse(this.DataDeVencimento) : throw new Exception("Data de Vencimento e obrigatoria");

        public DateTime DataDePagamentoFormatada => !string.IsNullOrEmpty(this.DataDePagamento) ? DateTime.Parse(this.DataDePagamento) : throw new Exception("Data de Pagamento e obrigatoria");



    }
}
