using Natanael.Aplicacao.API.Padrao;
using Natanael.Dominio.ContasPagar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.API.GestaoDeContasPagar.Modelos
{
    public class ModeloDeLista : ModeloPadrao
    {
        public ModeloDeLista()
        {
            this.Lista = new List<ModeloDeContaPagarDaLista>();
        }

        public ModeloDeLista(bool sucesso, string mensagem) : this()
        {
            this.Sucesso = sucesso;
            this.Mensagem = mensagem;
        }

        public ModeloDeLista(bool sucesso, string mensagem, List<ContaPagar> lista) : this()
        {
            
            this.Sucesso = sucesso;
            this.Mensagem = mensagem;

            if (lista == null)
                return;

            lista.ForEach(a => this.Lista.Add(new ModeloDeContaPagarDaLista(a)));
        }




        public List<ModeloDeContaPagarDaLista> Lista { get; private set; }
    }
}
