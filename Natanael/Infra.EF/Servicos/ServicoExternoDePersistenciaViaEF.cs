using Infra.EF.Context;
using Infra.EF.Repositorios;
using Natanael.Dominio.ContasPagar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EF.Servicos
{
    public class ServicoExternoDePersistenciaViaEF : IServicoExternoDePersistencia, IDisposable
    {
        private readonly Contexto _contexto;

        public ServicoExternoDePersistenciaViaEF(Contexto contexto)
        {
            this._contexto = contexto;
        }


        public IRepositorioDeContasPagar RepositorioDeContasPagar => new RepositoriosDeContasPagar(this._contexto);

        public void Dispose()
        {
            if (this._contexto != null)
                this._contexto.Dispose();

            GC.SuppressFinalize(this);
        }

        public void Persistir()
        {
            this._contexto.SaveChanges();
        }
    }
}
