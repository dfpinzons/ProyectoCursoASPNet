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
        /*[Route("Alumno/Index")]
        [Route("Alumno/Index/{asignaturaId}")]*/

        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {

                var alumno = from alumn in _context.Alumnos
                                 where alumn.Id == id
                                 select alumn;
                return View(alumno.SingleOrDefault());
            }
            else
            {
                return View("MultiAlumno", _context.Alumnos);
            }
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

