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
            modelBuilder.Enity<Cliente>(p =>
            {

            });
        }

    }
}
