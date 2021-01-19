using Infra.EF.Context;
using Natanael.Dominio.ContasPagar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EF.Repositorios
{
    public class RepositoriosDeContasPagar : IRepositorioDeContasPagar
    {
        private readonly Contexto _contexto;
        public RepositoriosDeContasPagar(Contexto contexto)
        {
            this._contexto = contexto;
        }
        public void Cadastrar(ContaPagar contaPagar)
        {
            throw new NotImplementedException();
        }

        public List<ContaPagar> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
