using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.API.Padrao
{
    public class ModeloDeRetornoPadrao
    {
        public ModeloDeRetornoPadrao()
        {

        }

        public ModeloDeRetornoPadrao(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public bool Sucesso { get; set; }

        public string Mensagem { get; set; }
    }
}
