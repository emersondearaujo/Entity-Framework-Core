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
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilders<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.Haskey(p => p.Id);
            builder.Property(p => p.CodigoBarras).HasColumnType("VARCHAR(80)").IsRequerid();
            builder.Property(p => p.Descricao).HasColumnType("CHAR(11)").IsRequerid();
            builder.Property(p => p.Valor).IsRequerid();

            //builder.HasMany(p => p.Itens).WhiteOne(p => p.Pedido).OrDelete(DeleteBehavior.Cascade);
        }
    }
}
