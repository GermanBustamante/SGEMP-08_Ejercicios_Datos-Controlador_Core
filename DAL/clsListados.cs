using System;
using System.Collections.ObjectModel;
using Entidades;
namespace DAL
{
    public class clsListados
    {
        public static String getDescripcionPlanta(String nombrePlanta)
        {
            String descripcionPlanta = null;
            foreach (string nombre in getListaNombresPlantasFrayGuillermo())
            {
                if (nombre == nombrePlanta)
                {
                    descripcionPlanta = 
                }
            }
            return null;
        }

        public static ObservableCollection<String> getListaNombresPlantasFrayGuillermo()
        {
            ObservableCollection<String> listadoPlantas = new ObservableCollection<String>();
            listadoPlantas.Add("Aloe Vera");
            listadoPlantas.Add("Valeriana");
            listadoPlantas.Add("Amapola");
            listadoPlantas.Add("Eucalipto");
            listadoPlantas.Add("Salvia");
            listadoPlantas.Add("Arándanos");
            return listadoPlantas;
        }
    }
}
