using Natanael.Aplicacao.API.GestaoDeContasPagar.Modelos;
using Natanael.Aplicacao.API.Padrao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.API.GestaoDeContasPagar.Servicos
{
    public interface IServicoDeGestaoDeContasPagar
    {
        ModeloDeLista Listar();

        ModeloPadrao Cadastrar(ModeloDeCadastroDeContaPagar modelo);
    }
}
