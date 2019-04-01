using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendasMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaVendasMvc.Services
{
    public class RegistroDeVendasService
    {
        private readonly SistemaVendasMvcContext _context;

        public RegistroDeVendasService(SistemaVendasMvcContext context)
        {
            _context = context;
        }

        public async  Task<List<RegistroDeVenda>> ProcuraPorDataAsync(DateTime? dataMin, DateTime? dataMax)
        {
            var result = from obj in _context.Vendas select obj;
            if(dataMin.HasValue)
            {
                result = result.Where(x => x.Data >= dataMin.Value);
            }
            if(dataMax.HasValue)
            {
                result = result.Where(x => x.Data <= dataMax.Value);
            }
            return await result.Include(x => x.Vendedor).Include(x => x.Vendedor.Departamento).OrderByDescending(x => x.Data).ToListAsync();
        }
        public async Task<List<IGrouping<Departamento,RegistroDeVenda>>> ProcuraPorDataAgrupadoAsync(DateTime? dataMin, DateTime? dataMax)
        {
            var result = from obj in _context.Vendas select obj;
            if (dataMin.HasValue)
            {
                result = result.Where(x => x.Data >= dataMin.Value);
            }
            if (dataMax.HasValue)
            {
                result = result.Where(x => x.Data <= dataMax.Value);
            }
            return await result.Include(x => x.Vendedor).Include(x => x.Vendedor.Departamento).OrderByDescending(x => x.Data).GroupBy(x=> x.Vendedor.Departamento).ToListAsync();
        }
    }
}
