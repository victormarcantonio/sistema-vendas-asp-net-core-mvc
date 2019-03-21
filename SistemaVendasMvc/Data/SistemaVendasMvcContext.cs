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

        public DbSet<SistemaVendasMvc.Models.Departamento> Departamento { get; set; }
    }
}
