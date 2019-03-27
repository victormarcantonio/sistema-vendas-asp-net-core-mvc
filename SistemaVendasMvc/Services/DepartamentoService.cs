using SistemaVendasMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendasMvc.Services
{
    public class DepartamentoService
    {
        private readonly SistemaVendasMvcContext _context;

        public DepartamentoService(SistemaVendasMvcContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x =>x.Nome).ToList();
        }
    }
}
