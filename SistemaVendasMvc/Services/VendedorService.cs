using SistemaVendasMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using SistemaVendasMvc.Services.Exceptions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaVendasMvc.Services
{
    public class VendedorService
    {
        private readonly SistemaVendasMvcContext _context;

        public VendedorService(SistemaVendasMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Vendedor>>FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async  Task InsertAsync(Vendedor obj)
        {
            _context.Add(obj);
           await _context.SaveChangesAsync();
        }
        public async Task <Vendedor> FindByIdAsync(int id)
        {
            return await _context.Vendedor.Include(obj=> obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);

        }
        public async Task RemoverAsync(int id)
        {
            var obj = await _context.Vendedor.FindAsync(id);
            _context.Vendedor.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Vendedor obj)
        {
            bool hasAny = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);
            if(!hasAny)
            {
                throw new NotFoundException("Id não existe");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();

            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
