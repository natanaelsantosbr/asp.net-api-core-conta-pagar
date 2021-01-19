using Microsoft.EntityFrameworkCore;
using Natanael.Dominio.ContasPagar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EF.Context
{
    public class Contexto : DbContext
    {
        public DbSet<ContaPagar> ContasPagar{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapeamentoDeContasPagar());
        }

    }
}
