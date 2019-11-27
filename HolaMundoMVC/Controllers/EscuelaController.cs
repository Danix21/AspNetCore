using System;
using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela
            {
                AñoDeCreación = 2005,
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Platzi School",
                Ciudad = "Bs As",
                Pais = "Argentina",
                Dirección = "Guido 2860",
                TipoEscuela = TiposEscuela.Secundaria
            };
            return View(escuela);
        }
    }
}