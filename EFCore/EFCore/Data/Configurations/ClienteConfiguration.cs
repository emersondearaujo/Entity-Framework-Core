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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilders<Cliente> builder)
        {
                builder.ToTable("Cliente");
                builder.Haskey(p => p.Id);
                builder.Property(p => p.Name).HasCollumnType("VARCHAR(80)").IsRequired();
                builder.Property(p => p.Telefone).HasColumnType("CHAR(11)").IsRequired();
                builder.Property(p => p.Cep).HasColumnType("CHAR(8)").IsRequired();
                builder.Property(p => p.Estado).HasColumnType("CHAR(8)").IsRequired();
                builder.Property(p => p.Cidade).HasMaxLenght(68).IsRequired();
                //builder.HasIndex(i => i.Telefone).HasName("idx_cliente_telefone"); //Utilizado para a criação da base de dados

        }
    }
}
