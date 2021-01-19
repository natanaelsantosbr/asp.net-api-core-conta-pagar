using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Dominio.ContasPagar
{
    public interface IRepositorioDeContasPagar
    {
        List<ContaPagar> Listar();

        void Cadastrar(ContaPagar contaPagar);
    }
}
