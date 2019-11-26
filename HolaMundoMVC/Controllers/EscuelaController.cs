using System;
using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela{
                AñoFundacion = 2005,
                EscuelaId = Guid.NewGuid().ToString(),
                Nombre = "Platzi School"
            };
            return View(escuela);
        }
    }
}