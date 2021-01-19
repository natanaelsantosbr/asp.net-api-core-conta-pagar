using Natanael.Dominio.ContasPagar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EF.Servicos
{
    public interface IServicoExternoDePersistencia
    {
        IRepositorioDeContasPagar RepositorioDeContasPagar { get; }

        void Persistir();
    }
}
