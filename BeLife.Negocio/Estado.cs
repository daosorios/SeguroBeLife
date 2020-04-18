using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Negocio
{
    public class Estado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Estado()
        {
            this.Init();
        }

        private void Init()
        {
            Id = 0;
            Descripcion = string.Empty;
        }

        public List<Estado> ReadAllEstado()
        {

            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();

            try
            {
                /* Se obtiene todos los registro desde la tabla */
                var listadoDatos = bbdd.EstadoCivil.ToList();

                /* Se convierte el listado de datos en un listado de negocio */
                List<Estado> listadoEstado = GenerarListado(listadoDatos);

                /* Se retorna la lista */
                return listadoEstado;
            }
            catch (Exception )
            {
                return new List<Estado>();

            }

        }

        private List<Estado> GenerarListado(List<Datos.EstadoCivil> listadoDatos)
        {
            List<Estado> listadoEstado = new List<Estado>();

            foreach (Datos.EstadoCivil dato in listadoDatos)
            {

                Estado esta = new Estado();
                CommonBC.Syncronize(dato, esta);

                listadoEstado.Add(esta);
            }

            return listadoEstado;
        }
    }
}
