using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.API.Padrao
{
    public class ModeloPadrao
    {
        public ModeloPadrao()
        {

        }

        public ModeloPadrao(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public bool Sucesso { get; set; }

        public string Mensagem { get; set; }
    }
}
