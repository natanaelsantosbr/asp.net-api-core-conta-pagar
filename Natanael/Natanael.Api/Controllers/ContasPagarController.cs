using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Natanael.Aplicacao.API.GestaoDeContasPagar.Modelos;
using Natanael.Aplicacao.API.GestaoDeContasPagar.Servicos;
using Natanael.Aplicacao.API.Padrao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natanael.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasPagarController : ControllerBase
    {
        private IServicoDeGestaoDeContasPagar _servicoDeGestaoDeContasPagar;

        public ContasPagarController(IServicoDeGestaoDeContasPagar servicoDeGestaoDeContasPagar)
        {
            this._servicoDeGestaoDeContasPagar = servicoDeGestaoDeContasPagar;
        }

        [HttpGet]
        public ActionResult<ModeloDeLista> Get()
        {
            var modelo = this._servicoDeGestaoDeContasPagar.Listar();

            return modelo;
        }

        [HttpPost]
        public ActionResult<ModeloPadrao> Post([FromBody] ModeloDeCadastroDeContaPagar modelo)
        {
            var retorno = this._servicoDeGestaoDeContasPagar.Cadastrar(modelo);

            return retorno;
        }
    }
}
