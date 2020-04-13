using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroBeLife
{
    class Sexo
    {
        public int IdSexo { get; set; }
        public string Descripcion { get; set; }

        public Sexo()
        {
            this.Init();
        }

        void Init()
        {
            IdSexo = 0;
            Descripcion = String.Empty;
        }
        public List<Sexo> ReadAll()
        {
            BeLife.Datos.BeLifeEntities bbdd = new BeLife.Datos.BeLifeEntities();

            try
            {
                /* Se obtiene todos los registro desde la tabla */
                List<BeLife.Datos.Sexo> listadoDatos = bbdd.Sexo.ToList<BeLife.Datos.Sexo>();

                /* Se convierte el listado de datos en un listado de negocio */
                List<Sexo> listadoSexo = GenerarListado(listadoDatos);

                /* Se retorna la lista */
                return listadoSexo;
            }
            catch (Exception ex)
            {
                return new List<Sexo>();
            }
        }
        private List<Sexo> GenerarListado(List<BeLife.Datos.Sexo> listadoDatos)
        {
            List<Sexo> listadoEmpresa = new List<Sexo>();

            foreach (BeLife.Datos.Sexo dato in listadoDatos)
            {

                Sexo sex = new Sexo();
                Join.Syncronize(dato, sex);

                listadoEmpresa.Add(sex);
            }

            return listadoEmpresa;
        }
    }
}
