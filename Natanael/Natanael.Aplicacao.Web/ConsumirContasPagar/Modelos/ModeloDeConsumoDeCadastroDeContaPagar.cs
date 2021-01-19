using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.Web.ConsumirContasPagar.Modelos
{
    public class ModeloDeConsumoDeCadastroDeContaPagar
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string DataDeVencimento { get; set; }
        public string DataDePagamento { get; set; }
    }
}
