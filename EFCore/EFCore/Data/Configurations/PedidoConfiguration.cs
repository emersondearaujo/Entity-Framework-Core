using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameWorkCore.Metdata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilders<Pedido> builder)
        {
                builder.ToTable("Pedido");
                builder.Haskey(p => p.Id);
                builder.Property(p => p.Status).HasConversion<String>();
                builder.Property(p => p.TipoFrete).HasasConversion<String>();
                builder.Property(p => p.Observacao).HasHasColumnType("CHAR(502)").IsRequerid();
         }
    }
}
