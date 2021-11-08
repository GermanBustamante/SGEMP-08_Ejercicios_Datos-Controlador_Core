using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using DAL;

namespace SGEMP_08_Ejercicios_Datos_Controlador_Core_UI.Models
{
    public class clsIndexVM
    {

        public ObservableCollection<String> Nombres { get; set; }

        public String Descripcion { get; set; }

        public clsIndexVM()
        {
            Nombres = clsListados.getListadoNombresPlantas();
            Descripcion = "";
        }

        public clsIndexVM(String nombrePlanta)
        {
            Nombres = clsListados.getListadoNombresPlantas();
            Descripcion = clsListados.getDetallesPlanta(nombrePlanta);
        }
    }
}
