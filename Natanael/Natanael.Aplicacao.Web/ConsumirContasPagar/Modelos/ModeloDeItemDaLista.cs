namespace Natanael.Aplicacao.Web.ConsumirContasPagar.Modelos
{
    public class ModeloDeItemDaLista
    {
        public string Nome { get;  set; }
        public string Valor { get; set; }
        public string ValorCorrigido { get; set; }
        public int QuantidadeDeDiasDeAtraso { get; set; }
        public string DataDePagamento { get; set; }
    }
}