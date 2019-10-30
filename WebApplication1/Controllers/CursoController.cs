using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers

{
    public class CursoController : Controller
    {
        /*[Route("Alumno/Index")]
        [Route("Alumno/Index/{asignaturaId}")]*/

        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {

                var curso = from cur in _context.Cursos
                             where cur.Id == id
                                 select cur;
                return View(curso.SingleOrDefault());
            }
            else
            {
                return View("MultiCurso", _context.Cursos);
            }
        }
        public IActionResult MultiCurso()
        {
           

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            // El view es el Index.cshtml de View/Escuela
            return View("MultiCurso", _context.Cursos);

        }

        public IActionResult Create()
        {


            ViewBag.Fecha = DateTime.Now;
            return View();

        }

        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            // context is de DB connection
            _context = context;
        }
    }
}

