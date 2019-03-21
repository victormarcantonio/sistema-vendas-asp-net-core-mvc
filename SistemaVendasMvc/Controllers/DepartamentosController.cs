using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendasMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace SistemaVendasMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletrônicos" });
            list.Add(new Departamento { Id = 2, Nome = "Roupas" });

            return View(list);
        }
    }
}