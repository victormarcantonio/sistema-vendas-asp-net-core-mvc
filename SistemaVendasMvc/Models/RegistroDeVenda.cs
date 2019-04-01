using System;
using SistemaVendasMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendasMvc.Models
{
    public class RegistroDeVenda
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double Quantia { get; set; }
        public StatusVenda Status{ get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroDeVenda()
        {

        }

        public RegistroDeVenda(int id, DateTime data, double quantia, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
