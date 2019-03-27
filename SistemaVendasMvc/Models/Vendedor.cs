using System;
using System.Collections.Generic;
using System.Linq;
namespace SistemaVendasMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroDeVenda> Vendas { get; set; } = new List<RegistroDeVenda>();


        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVendas(RegistroDeVenda rv)
        {
            Vendas.Add(rv);
        }

        public void RemoveVendas(RegistroDeVenda rv)
        {
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime inicio, DateTime fim)
        {
            return Vendas.Where(rv => rv.Data >= inicio && rv.Data <= fim).Sum(rv => rv.Quantia);
        }

    }
}
