using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers

{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            return View(_context.Asignaturas.FirstOrDefault());
        }
            public IActionResult MultiAsignatura()
        {
            

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            // El view es el Index.cshtml de View/Escuela
            return View("MultiAsignatura", _context.Asignaturas);
          
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            // context is de DB connection
            _context = context;
        }
    }
}
