using MicrosoftEnityFrameworkCore;
using EFCore.Data;
using EFCore.Domain;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using EFCore.Data.Configurations;

namespace EFCore.Data
{
    public class AplicationContext : DbContext
    {
        DbSet<Pedido> pedidos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mysqllocaldb; initial CatalogEFCore; Integrated Security=true");
        }
        protected override void OnModelCreate(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoItemConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());

            //modelBuilder.ApplyConfigurationFromAssembly(typeof(AplicationContext).Assembly);
        }
}
