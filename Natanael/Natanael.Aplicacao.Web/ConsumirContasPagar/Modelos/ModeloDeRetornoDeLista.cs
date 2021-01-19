using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.Web.ConsumirContasPagar.Modelos
{
    public class ModeloDeRetornoDeLista
    {
        public bool Sucesso { get; set; }

        public string Mensagem { get; set; }

        public List<ModeloDeItemDaLista> Lista { get; set; }
    }
}
