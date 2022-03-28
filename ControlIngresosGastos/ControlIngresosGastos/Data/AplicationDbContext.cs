using ControlIngresosGastos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlIngresosGastos.Data
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base (options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<IngresoGasto> IngresoGasto { get; set; }
    }
}
