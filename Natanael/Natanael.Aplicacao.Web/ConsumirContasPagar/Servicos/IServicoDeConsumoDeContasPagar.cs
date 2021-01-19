using Natanael.Aplicacao.Web.ConsumirContasPagar.Modelos;
using Natanael.Aplicacao.Web.Padrao;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Natanael.Aplicacao.Web.ConsumirContasPagar.Servicos
{
    public interface IServicoDeConsumoDeContasPagar
    {
        Task<ModeloDeRetornoDeLista> Listar();

        Task<ModeloDeRetornoPadrao> Cadastrar(ModeloDeConsumoDeCadastroDeContaPagar modelo);
    }
}
