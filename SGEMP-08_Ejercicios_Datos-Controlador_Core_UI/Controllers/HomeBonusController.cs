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
            clsIndexVM oIndexVM = new clsIndexVM();
            return View(oIndexVM);
        }

        [HttpPost]
        public IActionResult Index(String selectPlantas)
        {

            clsIndexVM oIndexVM = new clsIndexVM(selectPlantas);
            
            return View(oIndexVM);
        }
    }
}
