using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers

{
    public class EscuelaController : Controller
    {
        // Tipo generico
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoFundacion = 2005;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi";
            ViewBag.CosaDinamica = "La Monja";
            
            // El view es el Index.cshtml de View/Escuela
            return View(escuela);
        }

    }
}
