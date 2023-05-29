using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameWorkCore.Metdata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Configurations
{
    public class PedidoItemConfiguration : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilders<PedidoItem> builder)
        {
            builder.ToTable("PedidoItem");
            builder.Haskey(p => p.Id);
            builder.Property(p => p.Quantidade).HasDefaultValue(1).IsRequerid();
            builder.Property(p => p.Valor).IsRequerid();
            builder.Property(p => p.Desconto).IsRequerid();
        }
    }
}
