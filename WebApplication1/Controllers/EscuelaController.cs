using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Views.Escuela
{
    public class EscuelaController : Controller
    {
        // Tipo generico
        public IActionResult Index()
        {
            // El view es el Index.cshtml de View/Escuela
            return View();
        }

    }
}
