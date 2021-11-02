using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGEMP_08_Ejercicios_Datos_Controlador_Core_UI.Controllers
{
    public class Home2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Saludo(string nombre)
        {
            ViewBag.Nombre = nombre;
            return View();
        }
    }
}
