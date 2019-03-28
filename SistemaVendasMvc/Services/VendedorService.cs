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

        public List<Vendedor>FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Vendedor FindById(int id)
        {
            return _context.Vendedor.Include(obj=> obj.Departamento).FirstOrDefault(obj => obj.Id == id);

        }
        public void Remover(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }

        public void Atualizar(Vendedor obj)
        {
            if(!_context.Vendedor.Any(x=> x.Id== obj.Id))
            {
                throw new NotFoundException("Id não existe");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();

            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
