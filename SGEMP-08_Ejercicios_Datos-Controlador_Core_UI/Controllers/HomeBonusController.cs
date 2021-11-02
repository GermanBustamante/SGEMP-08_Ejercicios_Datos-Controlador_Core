using Microsoft.AspNetCore.Mvc;
using SGEMP_08_Ejercicios_Datos_Controlador_Core_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGEMP_08_Ejercicios_Datos_Controlador_Core_UI.Controllers
{
    public class HomeBonusController : Controller
    {
        public IActionResult Index()
        {
            clsIndexVM c = new clsIndexVM();
            return View(c);
        }
    }
}
