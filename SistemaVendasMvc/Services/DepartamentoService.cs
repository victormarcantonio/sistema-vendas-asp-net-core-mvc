using SistemaVendasMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaVendasMvc.Services
{
    public class DepartamentoService
    {
        private readonly SistemaVendasMvcContext _context;

        public DepartamentoService(SistemaVendasMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento>> FindAllAsync()
        {
            return await _context.Departamento.OrderBy(x =>x.Nome).ToListAsync();
        }
    }
}
