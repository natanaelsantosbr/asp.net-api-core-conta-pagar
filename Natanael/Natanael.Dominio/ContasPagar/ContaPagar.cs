using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Dominio.ContasPagar
{
    public class ContaPagar : Entidade
    {
        public ContaPagar()
        {

        }

        public ContaPagar(string nome, double valor, DateTime dataDeVencimento, DateTime dataDePagamento) : this()
        {
            this.Nome = nome;
            this.Valor = valor;
            this.DataDeVencimento = dataDeVencimento;
            this.DataDePagamento = dataDePagamento;

            this.ProcessarFinanceiro();


        }

        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public DateTime DataDeVencimento { get; private set; }
        public DateTime DataDePagamento { get; private set; }
        public int DiasDeAtraso { get; private set; }
        public double PercentualDaMulta { get; private set; }
        public double ValorDaMulta { get; private set; }
        public double PercentualDosJuros { get; private set; }
        public double ValorDosJuros { get; private set; }

        private void ProcessarFinanceiro()
        {
            this.DiasDeAtraso = 10;
            this.PercentualDaMulta = 10.0;
            this.ValorDaMulta = 15.00;
            this.PercentualDosJuros = 5.00;
            this.ValorDosJuros = 10.0;
        }
    }
}
