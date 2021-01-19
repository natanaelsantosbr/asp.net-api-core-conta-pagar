using Infra.EF.Servicos;
using Natanael.Aplicacao.API.GestaoDeContasPagar.Modelos;
using Natanael.Aplicacao.API.Padrao;
using Natanael.Dominio.ContasPagar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.API.GestaoDeContasPagar.Servicos
{
    public class ServicoDeGestaoDeContasPagar : IServicoDeGestaoDeContasPagar
    {
        private readonly IServicoExternoDePersistencia _servicoExternoDePersistencia;

        public ServicoDeGestaoDeContasPagar(IServicoExternoDePersistencia servicoExternoDePersistencia)
        {
            this._servicoExternoDePersistencia = servicoExternoDePersistencia;
        }

        public ModeloDeRetornoPadrao Cadastrar(ModeloDeCadastroDeContaPagar modelo)
        {
            try
            {
                var contaPagar = new ContaPagar(modelo.Nome, modelo.ValorFormatado, modelo.DataDeVencimentoFormatada, modelo.DataDePagamentoFormatada);

                this._servicoExternoDePersistencia.RepositorioDeContasPagar.Cadastrar(contaPagar);
                this._servicoExternoDePersistencia.Persistir();

                return new ModeloDeRetornoPadrao(true, "Conta Pagar cadastrada com sucesso");

            }
            catch (Exception ex)
            {
                return new ModeloDeRetornoPadrao(false, ex.Message);
            }
        }

        public ModeloDeRetornoDaLista Listar()
        {
            try
            {
                var contas = this._servicoExternoDePersistencia.RepositorioDeContasPagar.Listar();

                return new ModeloDeRetornoDaLista(true, "ok", contas);
            }
            catch (Exception ex)
            {
                return new ModeloDeRetornoDaLista(false, ex.Message);
            }
        }
    }
}
