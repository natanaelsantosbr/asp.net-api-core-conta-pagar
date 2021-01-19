using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Natanael.Dominio.ContasPagar;

namespace Infra.EF.Mapeamentos
{
    public class MapeamentoDeContasPagar : IEntityTypeConfiguration<ContaPagar>
    {
        public void Configure(EntityTypeBuilder<ContaPagar> builder)
        {
            builder.ToTable("ContasPagar");
        }
    }
}