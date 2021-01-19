using Infra.EF.Context;
using Natanael.Dominio.ContasPagar;
using System;
using System.Collections.Generic;
using System.Linq;
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
            this._contexto.Add(contaPagar);
        }

        public List<ContaPagar> Listar()
        {
            return this._contexto.Set<ContaPagar>().OrderByDescending(a => a.Id).ToList();
        }
    }
}
