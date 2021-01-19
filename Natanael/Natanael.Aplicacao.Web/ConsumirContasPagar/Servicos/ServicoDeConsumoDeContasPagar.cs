using Natanael.Aplicacao.Web.ConsumirContasPagar.Modelos;
using Natanael.Aplicacao.Web.Padrao;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Natanael.Aplicacao.Web.ConsumirContasPagar.Servicos
{
    public class ServicoDeConsumoDeContasPagar : IServicoDeConsumoDeContasPagar
    {
        public async Task<ModeloDeRetornoPadrao> Cadastrar(ModeloDeConsumoDeCadastroDeContaPagar modelo)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(modelo), Encoding.UTF8, "application/json");

                using (var resposta = await httpClient.PostAsync("https://localhost:44326/api/contaspagar", content))
                {
                    string apiResposta = await resposta.Content.ReadAsStringAsync();
                    var retorno = JsonConvert.DeserializeObject<ModeloDeRetornoPadrao>(apiResposta);

                    return retorno;
                }
            }
        }

        public async Task<ModeloDeRetornoDeLista> Listar()
        {
            var modelo = new ModeloDeRetornoDeLista();

            using (var httpClient = new HttpClient())
            {
                using (var resposta = await httpClient.GetAsync("https://localhost:44326/api/contaspagar"))
                {
                    string apiResposta = await resposta.Content.ReadAsStringAsync();
                    modelo = JsonConvert.DeserializeObject<ModeloDeRetornoDeLista>(apiResposta);
                }
            }

            return modelo;
        }
    }
}
