using SistemaVendasMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
