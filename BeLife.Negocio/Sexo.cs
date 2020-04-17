using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Negocio
{
    public class Sexo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Sexo()
        {
            this.Init();
        }

        private void Init()
        {
            Id = 0;
            Descripcion = string.Empty;
        }

        public List<Sexo> ReadAllSexo()
        {

            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();

            try
            {
                /* Se obtiene todos los registro desde la tabla */
                var listadoDatos = bbdd.Sexo.ToList();

                /* Se convierte el listado de datos en un listado de negocio */
                List<Sexo> listadoSexo = GenerarListado(listadoDatos);

                /* Se retorna la lista */
                return listadoSexo;
            }
            catch (Exception )
            {
                return new List<Sexo>();

            }
        }

    
        private List<Sexo> GenerarListado(List<Datos.Sexo> listadoDatos)
        {
            List<Sexo> listadoSexo = new List<Sexo>();

            foreach (Datos.Sexo dato in listadoDatos)
            {

                Sexo sex = new Sexo();
                CommonBC.Syncronize(dato, sex);

                listadoSexo.Add(sex);
            }

            return listadoSexo;
        }
    }
}

