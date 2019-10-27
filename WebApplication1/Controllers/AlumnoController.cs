using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers

{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View(_context.Alumnos.FirstOrDefault());
        }
        public IActionResult MultiAlumno()
        {
           

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            // El view es el Index.cshtml de View/Escuela
            return View("MultiAlumno", _context.Alumnos);

        }

        

        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            // context is de DB connection
            _context = context;
        }
    }
}

