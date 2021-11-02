using System;
using System.Collections.ObjectModel;
using Entidades;
namespace DAL
{
    public class clsListados
    {
        public static ObservableCollection<clsPlanta> getListaPlantasFrayGuillermo()
        {
            ObservableCollection<clsPlanta> listadoPlantas = new ObservableCollection<clsPlanta>();
            listadoPlantas.Add(new clsPlanta("Aloe Vera", "De la familia de las Asphodelaceae, pertenece al género Aloe, que cuenta con más de 350 especies vegetales. Esta especie, muy habitual entre las plantas de interior, tiene infinidad de aplicaciones en diversos remedios naturales, especialmente para los de la piel. Entre ellas, la de aliviar las quemaduras, rozaduras e, incluso, psoriasis y picaduras de insectos."));
            listadoPlantas.Add(new clsPlanta("Valeriana", "La valeriana o Valeriana officinalis es una de las plantas medicinales más empleadas en la fitoterapia. Y es normal, ya que tiene infinidad de beneficios pero quizás el más conocido sea el ayudar a relajarnos. La valeriana es una planta que disminuye la ansiedad y ayuda a dormir."));
            listadoPlantas.Add(new clsPlanta("Amapola", "La amapola o Papaver rhoeas L., es una planta curativa de la que se usan las semillas. Con estas semillas se consigue prevenir enfermedades cardiovasculares, anemias o afecciones de la piel."));
            listadoPlantas.Add(new clsPlanta("Eucalipto", "El eucalipto o eucaliptas es una de las plantas que más usamos para decorar la casa. Son plantas muy resistentes y perfectas para añadir a cualquier centro de mesa. Pero además de decorar el interior de nuestra casa, los eucaliptos son plantas medicinales muy beneficiosas para la salud. Entre sus propiedades más conocidas está la de aliviar los síntomas de los resfriados, en concreto afecciones respiratorias (tos, bronquitis, neumonía, asma...)."));
            listadoPlantas.Add(new clsPlanta("Salvia", "La salvia o Salvia officinalis es una de las plantas más conocidas por utilizarse en cosméticos, pero también tiene otras funciones. Entre las más conocidas está su utilización para aliviar los síntomas de la menopausia."));
            listadoPlantas.Add(new clsPlanta("Arándanos", "Los arándanos o también llamado como cranberry (o Vaccinium macrocarpon) junto con las frambuesas son algunos de los ingredientes principales de los boles que más verás en un desayuno saludable. Pues bien, los arándanos, muy populares en la fitoterapia, a pesar de ser muy pequeños, cuentan con muchas propiedades, entre las que destaca su capacidad antibacteriana, ya que ayuda a combatir infecciones. "));
            return listadoPlantas;
        }
        public static String getDescripcionPlanta(String nombrePlanta)
        {
            String descripcionPlanta = null;
            bool encontrado = false;
            for (int i = 0; i <= getListaPlantasFrayGuillermo().Count; i++)
            {
                if  == nombrePlanta)
                {
                    descripcionPlanta = planta.Descripcion;
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
