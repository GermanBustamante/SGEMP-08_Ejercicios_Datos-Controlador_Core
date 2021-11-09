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
        //1--> HACER CON LOS CONSTRUCTORES, USANDO DE PARAMETROS EL NOMBRE DE LA PLANTA
        //2--> IR AL CONTROLADOR Y LUEGO DE CONSTRUIRLO SOLO CON LA LISTA. LUEGO, HACER SET DESCRIPCION Y LE PASAS EL NOMBRE
        //RECOGIDO DEL VIEWINDEX, LLAMANDO EL SETTER AL MÉTODO GETDETALLESPLANTA(NOMBREPLANTA)
        //3--> JUANJO
        //NOTA: EL CONTROLLER TAMBIÉN PUEDE ACCEDER A LA CAPA DAL

        public List<String> Nombres { get; set; }

        public String Descripcion { get; set; }

        public clsIndexVM()
        {
            Nombres = new clsListados().getListadoNombresPlantas();
            Descripcion = "";//NO ES OBLIGATORIO PERO PARA QUE QUEDE MÁS CLARO
        }

        public clsIndexVM(String nombrePlanta)
        {
            Nombres = new clsListados().getListadoNombresPlantas();
            Descripcion = new clsListados().getDetallesPlanta(nombrePlanta);
        }
    }
}
