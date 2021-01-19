using Microsoft.AspNetCore.Mvc;
using Natanael.Aplicacao.Web.ConsumirContasPagar.Modelos;
using Natanael.Aplicacao.Web.ConsumirContasPagar.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natanael.Web.Controllers
{
    public class ContasPagarController : Controller
    {
        private IServicoDeConsumoDeContasPagar _servicoDeConsumoDeContasPagar;

        public ContasPagarController(IServicoDeConsumoDeContasPagar servicoDeConsumoDeContasPagar)
        {
            this._servicoDeConsumoDeContasPagar = servicoDeConsumoDeContasPagar;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var retorno = await this._servicoDeConsumoDeContasPagar.Listar();

            return View(retorno);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(ModeloDeConsumoDeCadastroDeContaPagar modelo)
        {
            var retorno = await this._servicoDeConsumoDeContasPagar.Cadastrar(modelo);

            return RedirectToAction(nameof(Index));
        }
    }
}
