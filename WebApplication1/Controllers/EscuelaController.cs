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
           

            ViewBag.CosaDinamica = "La Monja";
            var escuela = _context.Escuelas.FirstOrDefault();
            // El view es el Index.cshtml de View/Escuela
            return View(escuela);
        }
        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context)
        {
        // context is de DB connection
            _context = context;
        }
    }
}
