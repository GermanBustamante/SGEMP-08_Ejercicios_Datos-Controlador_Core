using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGEMP_08_Ejercicios_Datos_Controlador_Core_UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Saludo(String nombre)
        {
            ViewBag.Nombre = nombre;//TODO PREGUNTAR RUTAS
            return View();
        }
    }
}
