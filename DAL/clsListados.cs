using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DAL
{
    public class clsListados
    {
        #region propiedades publicas
        public List<clsPlanta> listadoPlantas { get; set; }
        #endregion

        //SE PUEDE HACER ESTÁTICO
        #region constructores
        public clsListados()
        {
            listadoPlantas = getListaPlantasFrayGuillermo();
        }
        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public String getDetallesPlanta(String nombre)
        {
            return nombre == "" ? "":(listadoPlantas.Find(plant => plant.Nombre.Equals(nombre)).Descripcion);
            //ojo, observableCollection no tiene Find()
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<String> getListadoNombresPlantas()
        {
            List<String> listadoNombresPlantas = new List<string>();
            foreach (clsPlanta oPlanta in listadoPlantas)
            {
                listadoNombresPlantas.Add(oPlanta.Nombre);
            }
            return listadoNombresPlantas;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<clsPlanta> getListaPlantasFrayGuillermo()
        {
            List<clsPlanta> listadoPlantas = new List<clsPlanta>();
            listadoPlantas.Add(new clsPlanta("Aloe Vera", "De la familia de las Asphodelaceae, pertenece al género Aloe, que cuenta con más de 350 especies vegetales. Esta especie, muy habitual entre las plantas de interior, tiene infinidad de aplicaciones en diversos remedios naturales, especialmente para los de la piel. Entre ellas, la de aliviar las quemaduras, rozaduras e, incluso, psoriasis y picaduras de insectos."));
            listadoPlantas.Add(new clsPlanta("Valeriana", "La valeriana o Valeriana officinalis es una de las plantas medicinales más empleadas en la fitoterapia. Y es normal, ya que tiene infinidad de beneficios pero quizás el más conocido sea el ayudar a relajarnos. La valeriana es una planta que disminuye la ansiedad y ayuda a dormir."));
            listadoPlantas.Add(new clsPlanta("Amapola", "La amapola o Papaver rhoeas L., es una planta curativa de la que se usan las semillas. Con estas semillas se consigue prevenir enfermedades cardiovasculares, anemias o afecciones de la piel."));
            listadoPlantas.Add(new clsPlanta("Eucalipto", "El eucalipto o eucaliptas es una de las plantas que más usamos para decorar la casa. Son plantas muy resistentes y perfectas para añadir a cualquier centro de mesa. Pero además de decorar el interior de nuestra casa, los eucaliptos son plantas medicinales muy beneficiosas para la salud. Entre sus propiedades más conocidas está la de aliviar los síntomas de los resfriados, en concreto afecciones respiratorias (tos, bronquitis, neumonía, asma...)."));
            listadoPlantas.Add(new clsPlanta("Salvia", "La salvia o Salvia officinalis es una de las plantas más conocidas por utilizarse en cosméticos, pero también tiene otras funciones. Entre las más conocidas está su utilización para aliviar los síntomas de la menopausia."));
            listadoPlantas.Add(new clsPlanta("Arándanos", "Los arándanos o también llamado como cranberry (o Vaccinium macrocarpon) junto con las frambuesas son algunos de los ingredientes principales de los boles que más verás en un desayuno saludable. Pues bien, los arándanos, muy populares en la fitoterapia, a pesar de ser muy pequeños, cuentan con muchas propiedades, entre las que destaca su capacidad antibacteriana, ya que ayuda a combatir infecciones. "));
            return listadoPlantas;
        }
    }
}
