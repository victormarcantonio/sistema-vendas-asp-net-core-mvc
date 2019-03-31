﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendasMvc.Services;

namespace SistemaVendasMvc.Controllers
{
    public class RegistroDeVendasController : Controller
    {
        private readonly RegistroDeVendasService _registroDeVendasService;

        public RegistroDeVendasController(RegistroDeVendasService registroDeVendasService)
        {
            _registroDeVendasService = registroDeVendasService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? dataMin, DateTime? dataMax)
        {
            if(!dataMin.HasValue)
            {
                dataMin = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if(!dataMax.HasValue)
            {
                dataMax =DateTime.Now;
            }
            ViewData["dataMin"] = dataMin.Value.ToString("yyyy-MM-dd");
            ViewData["dataMax"] = dataMax.Value.ToString("yyyy-MM-dd");
            var result = await _registroDeVendasService.ProcuraPorDataAsync(dataMin, dataMax);
            return View(result);
        }

        public IActionResult BuscaAgrupada()
        {
            return View();
        }
    }
}