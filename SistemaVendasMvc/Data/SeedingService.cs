using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendasMvc.Models.Enums;
using SistemaVendasMvc.Models;

namespace SistemaVendasMvc.Data
{
    public class SeedingService
    {
        private SistemaVendasMvcContext _context;

        public SeedingService(SistemaVendasMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departamento.Any()||_context.Vendedor.Any() || _context.Vendas.Any() )
            {
                return; //banco já foi populado
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletrônicos");
            Departamento d3 = new Departamento(3, "Roupas");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor v1 = new Vendedor(1, "Lucas Silva","lucas@hotmail.com", new DateTime(1994,11,29),1500.00,d1);
            Vendedor v2 = new Vendedor(2, "Guilherme Jesus", "gui@hotmail.com", new DateTime(1990,08,15), 3500.00, d2);
            Vendedor v3 = new Vendedor(3, "Maria Fernandes", "maria@hotmail.com", new DateTime(1988,03,22), 2200.00, d1);
            Vendedor v4 = new Vendedor(4, "Victor Sousa", "victor@hotmail.com", new DateTime(1997,03,19), 3000.00, d4);
            Vendedor v5 = new Vendedor(5, "Luana Lins", "luana@hotmail.com", new DateTime(2000,09,25), 4000.00, d3);
            Vendedor v6 = new Vendedor(6, "Paula Lima", "paula@hotmail.com", new DateTime(1993,02,04), 3000.00, d2);

            RegistroDeVenda r1 = new RegistroDeVenda(1, new DateTime(2018,09,25), 11000.00,StatusVenda.Faturado,v1);
            RegistroDeVenda r2 = new RegistroDeVenda(2, new DateTime(2018,09,4), 7000.0, StatusVenda.Faturado, v5);
            RegistroDeVenda r3 = new RegistroDeVenda(3, new DateTime(2018,09,13), 4000.0, StatusVenda.Cancelado, v4);
            RegistroDeVenda r4 = new RegistroDeVenda(4, new DateTime(2018,09,1), 8000.0, StatusVenda.Faturado, v1);
            RegistroDeVenda r5 = new RegistroDeVenda(5, new DateTime(2018,09,21), 3000.0, StatusVenda.Faturado, v3);
            RegistroDeVenda r6 = new RegistroDeVenda(6, new DateTime(2018,09,15), 2000.0, StatusVenda.Faturado, v1);
            RegistroDeVenda r7 = new RegistroDeVenda(7, new DateTime(2018,09,28), 13000.0, StatusVenda.Faturado, v2);
            RegistroDeVenda r8 = new RegistroDeVenda(8, new DateTime(2018,09,11), 4000.0, StatusVenda.Faturado, v4);
            RegistroDeVenda r9 = new RegistroDeVenda(9, new DateTime(2018,09,14), 11000.0, StatusVenda.Pendente, v6);
            RegistroDeVenda r10 = new RegistroDeVenda(10, new DateTime(2018,09,7), 9000.0, StatusVenda.Faturado, v6);
            RegistroDeVenda r11 = new RegistroDeVenda(11, new DateTime(2018,09,13), 6000.0, StatusVenda.Faturado, v2);
            RegistroDeVenda r12 = new RegistroDeVenda(12, new DateTime(2018,09,25), 7000.0, StatusVenda.Pendente, v3);
            RegistroDeVenda r13 = new RegistroDeVenda(13, new DateTime(2018,09,29), 10000.0, StatusVenda.Faturado, v4);
            RegistroDeVenda r14 = new RegistroDeVenda(14, new DateTime(2018,09,4), 3000.0, StatusVenda.Faturado, v5);
            RegistroDeVenda r15 = new RegistroDeVenda(15, new DateTime(2018,09,12), 4000.0, StatusVenda.Faturado, v1);
            RegistroDeVenda r16 = new RegistroDeVenda(16, new DateTime(2018,10,5), 2000.0, StatusVenda.Faturado, v4);
            RegistroDeVenda r17 = new RegistroDeVenda(17, new DateTime(2018,10,1), 12000.0, StatusVenda.Faturado, v1);
            RegistroDeVenda r18 = new RegistroDeVenda(18, new DateTime(2018,10,24), 6000.0, StatusVenda.Faturado, v3);
            RegistroDeVenda r19 = new RegistroDeVenda(19, new DateTime(2018,10,22), 8000.0, StatusVenda.Faturado, v5);
            RegistroDeVenda r20 = new RegistroDeVenda(20, new DateTime(2018,10,15), 8000.0, StatusVenda.Faturado, v6);
            RegistroDeVenda r21 = new RegistroDeVenda(21, new DateTime(2018,10,17), 9000.0, StatusVenda.Faturado, v2);
            RegistroDeVenda r22 = new RegistroDeVenda(22, new DateTime(2018,10,24), 4000.0, StatusVenda.Faturado, v4);
            RegistroDeVenda r23 = new RegistroDeVenda(23, new DateTime(2018,10,19), 11000.0, StatusVenda.Cancelado, v2);
            RegistroDeVenda r24 = new RegistroDeVenda(24, new DateTime(2018,10,12), 8000.0, StatusVenda.Faturado, v5);
            RegistroDeVenda r25 = new RegistroDeVenda(25, new DateTime(2018,10,31), 7000.0, StatusVenda.Faturado, v3);
            RegistroDeVenda r26 = new RegistroDeVenda(26, new DateTime(2018,10,6), 5000.0, StatusVenda.Faturado, v4);
            RegistroDeVenda r27 = new RegistroDeVenda(27, new DateTime(2018,10,13), 9000.0, StatusVenda.Pendente, v1);
            RegistroDeVenda r28 = new RegistroDeVenda(28, new DateTime(2018,10,7), 4000.0, StatusVenda.Faturado, v3);
            RegistroDeVenda r29 = new RegistroDeVenda(29, new DateTime(2018,10,23), 12000.0, StatusVenda.Faturado, v5);
            RegistroDeVenda r30 = new RegistroDeVenda(30, new DateTime(2018,10,12), 5000.0, StatusVenda.Faturado, v2);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);
            _context.Vendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
