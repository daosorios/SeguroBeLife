using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Negocio
{

    public class Plan
    {

        public String IdPlan { get; set; }
        public String Nombre { get; set; }
        public float PrimaBase { get; set; }
        public String PolizaActual { get; set; }

        public Plan()
        {
            this.Init();
        }

        private void Init()
        {
            IdPlan = String.Empty;
            Nombre = String.Empty;
            PrimaBase = 0;
            PolizaActual = String.Empty;
        }


        public List<Plan> ReadAllPlan()
        {

            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();

            try
            {
                /* Se obtiene todos los registro desde la tabla */
                var listadoDatos = bbdd.Plan.ToList();

                /* Se convierte el listado de datos en un listado de negocio */
                List<Plan> listadoPlan = GenerarListado(listadoDatos);

                /* Se retorna la lista */
                return listadoPlan;
            }
            catch (Exception )
            {
                return new List<Plan>();

            }

        }

        private List<Plan> GenerarListado(List<BeLife.Datos.Plan> listadoDatos)
        {
            List<Plan> listadoPlan = new List<Plan>();

            foreach (Datos.Plan dato in listadoDatos)
            {

                Plan plan = new Plan();
                CommonBC.Syncronize(dato, plan);

                listadoPlan.Add(plan);
            }

            return listadoPlan;
        }
    }
}
