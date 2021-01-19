using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Dominio
{
    public class Entidade
    {
        public Entidade()
        {
            DataDoCadastro = DateTime.Now;
        }
        public int Id { get; private set; }

        public DateTime DataDoCadastro { get; private set; }
    }
}
