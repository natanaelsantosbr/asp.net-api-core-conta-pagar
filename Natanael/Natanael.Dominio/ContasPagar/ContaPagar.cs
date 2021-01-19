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
        public double PercentualDaMulta { get; private set; }
        public double ValorDaMulta { get; private set; }
        public double PercentualDosJuros { get; private set; }
        public double ValorDosJuros { get; private set; }
        public double ValorCorrigido { get; private set; }
        public int QuantidadeDeDiasEmAtraso { get; private set; }

        private void ProcessarFinanceiro()
        {
            var dias = this.TotalDeDias();

            if(dias > 0)
            {
                this.QuantidadeDeDiasEmAtraso = dias;

                if(dias >= 1 && dias <= 3)
                {
                    this.PercentualDaMulta = 2.00;
                    this.PercentualDosJuros = 0.1;
                }
                else if(dias > 3 && dias <= 5)
                {
                    this.PercentualDaMulta = 3.00;
                    this.PercentualDosJuros = 0.2;
                }
                else if(dias > 5)
                {
                    this.PercentualDaMulta = 5.00;
                    this.PercentualDosJuros = 0.3;
                }

                this.CalcularValorDaMulta();
                this.CalcularValorDosJuros();
                this.CalcularValorCorrigido();

            }
            else
            {
                this.QuantidadeDeDiasEmAtraso = 0;
                this.PercentualDaMulta = 0;
                this.PercentualDosJuros = 0;
                this.ValorDaMulta = 0;
                this.ValorDosJuros = 0;
                this.ValorCorrigido = this.Valor;

            }
        }

        private void CalcularValorCorrigido()
        {
            this.ValorCorrigido = this.Valor + (this.ValorDaMulta + this.ValorDosJuros);
        }

        private int TotalDeDias()
        {
            TimeSpan calculo = this.DataDePagamento.Subtract(this.DataDeVencimento);
            return (int)calculo.TotalDays;
        }

        private void CalcularValorDaMulta()
        {
            double percentual = this.PercentualDaMulta / 100;

            double multa = percentual * this.Valor;

            this.ValorDaMulta = multa;
        }

        private void CalcularValorDosJuros()
        {
            double percentualPorDiaDeAtraso = this.PercentualDosJuros * this.QuantidadeDeDiasEmAtraso;
            double juros = this.Valor * percentualPorDiaDeAtraso;

            this.ValorDosJuros = juros;
        }

    }
}
