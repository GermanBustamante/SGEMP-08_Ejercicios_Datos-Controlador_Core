using Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGEMP_08_Ejercicios_Datos_Controlador_Core_UI.Controllers
{
    public class Home3Controller : Controller
    {
        public IActionResult Index()
        {
            return View("Editar");
        }

        public IActionResult Editar()
        {
            return View(new clsPersona("Germán", "Bustamante", DateTime.Now, "Calle Simanca", 674568955));
        }

        public IActionResult PersonaModificada(clsPersona persona)
        {
            return View(persona);
        }
    }
}
