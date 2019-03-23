using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaVendasMvc.Models
{
    public class SistemaVendasMvcContext : DbContext
    {
        public SistemaVendasMvcContext (DbContextOptions<SistemaVendasMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet <Vendedor> Vendedor { get; set; }
        public DbSet <RegistroDeVenda> Vendas { get; set; }



    }
}
