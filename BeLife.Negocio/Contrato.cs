using BeLife.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Negocio
{
   public class Contrato
    {


        public string Numero { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string RutCliente { get; set; }
        public string CodigoPlan { get; set; }
        public System.DateTime FechaInicioVigencia { get; set; }
        public System.DateTime FechaFinVigencia { get; set; }
        public bool Vigente { get; set; }
        public bool DeclaracionSalud { get; set; }
        public double PrimaAnual { get; set; }
        public double PrimaMensual { get; set; }
        public string Observaciones { get; set; }


        public Contrato()
        {
            this.Init();
        }

        void Init()
        {
            Numero = string.Empty;
            FechaCreacion = DateTime.Today;
            RutCliente = string.Empty;
            CodigoPlan = string.Empty;
            FechaInicioVigencia = DateTime.Today;
            FechaFinVigencia = DateTime.Today;
            Vigente = true;
            DeclaracionSalud = true;
            PrimaAnual = 0.0;
            PrimaMensual = 0.0;
            Observaciones = string.Empty;

        }





        //LISTO EL CRUD 
        public bool CreateContrato()
        {
            //metodo crear contrato base de dato
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();
            Datos.Contrato con = new Datos.Contrato();

            try
            {
                CommonBC.Syncronize(this, con);

                bbdd.Contrato.Add(con);
                bbdd.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                bbdd.Contrato.Remove(con);
                return false;
            }
        }



        public bool ReadContrato()
        {
            //buscar en la base de datos 
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();

            try
            {
                /* Se obtiene el primer registro coincidente con el Rut */
                Datos.Contrato contrato = bbdd.Contrato.First(e => e.RutCliente == RutCliente);

                /* Se copian las propiedades de datos al negocio */
               CommonBC.Syncronize(contrato, this);

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool UpdateContrato()
        {
            //Actualizar contrato base de dato
           BeLifeEntities bbdd = new BeLifeEntities();
            /* Se obtiene el primer registro coincidente con el Rut */
            Datos.Contrato contrato = bbdd.Contrato.First(e => e.Numero == Numero);
            try
            {
                /* Se copian las propiedades del negocio a los datos */
                CommonBC.Syncronize(this, contrato);

                bbdd.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
       
            }



        }

        public bool DeleteContrato()
        {

            //metodo eliminar contrato base de dato
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();

            try
            {                
                Datos.Contrato contrato = bbdd.Contrato.First(e => e.RutCliente == RutCliente);

                CommonBC.Syncronize(this, contrato);

                bbdd.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Contrato> ReadAll()
        {

            //lee todos los registros de los contratos
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();

            try
            {
                /* Se obtiene todos los registro desde la tabla */
                List<Datos.Contrato> listadoDatos = bbdd.Contrato.ToList<Datos.Contrato>();

                /* Se convierte el listado de datos en un listado de negocio */
                List<Contrato> listadoContrato = GenerarListado(listadoDatos);

                /* Se retorna la lista */
                return listadoContrato;
            }
            catch (Exception)
            {
                return new List<Contrato>();
            }
        }

        /// <summary>
        /// Convierte un listado de objetos de datos en un listado de objetos de negocio (contra)
        /// </summary>
        /// <param name="listadoDatos"></param>
        /// <returns></returns>
        private List<Contrato> GenerarListado(List<Datos.Contrato> listadoDatos)
        {
            List<Contrato> listadoContrato = new List<Contrato>();

            foreach (Datos.Contrato dato in listadoDatos)
            {

                Contrato contra = new Contrato();
                CommonBC.Syncronize(dato, contra);

                listadoContrato.Add(contra);
            }

            return listadoContrato;
        }


        //public IEnumerable<Contrato> ReadSF(string numero, String rut, string poliza)
        //{
        //    if (rut.Length > 0 && numero.Length > 0 && poliza.Length > 0)
        //    {
        //        IEnumerable<Contrato> abc = from d in ReadAll()
        //                                    where d.RutCliente == rut && d.Numero == numero.ToString() && d.CodigoPlan == poliza.ToString()
        //                                    select d;
        //        return abc;
        //    }

        //    else if (rut.Length > 0 && numero.Length > 0 && poliza.Length == 0)
        //    {
        //        IEnumerable<Contrato> ab = from d in ReadAll()
        //                                   where d.RutCliente == rut && d.Numero == numero.ToString()
        //                                   select d;
        //        return ab;
        //    }


        //    else if (rut.Length > 0 && numero.Length == 0 && poliza.Length > 0)
        //    {
        //        IEnumerable<Contrato> ac = from d in ReadAll()
        //                                   where d.RutCliente == rut && d.CodigoPlan == poliza.ToString()
        //                                   select d;
        //        return ac;
        //    }

        //    else if (rut.Length > 0 && numero.Length == 0 && poliza.Length == 0)
        //    {
        //        IEnumerable<Contrato> a = from d in ReadAll()
        //                                  where d.RutCliente == rut
        //                                  select d;
        //        return a;
        //    }

        //    else if (numero.Length > 0 && poliza.Length > 0)
        //    {
        //        IEnumerable<Contrato> ac = from d in ReadAll()
        //                                   where d.Numero == numero.ToString() && d.CodigoPlan == poliza.ToString()
        //                                   select d;
        //        return ac;
        //    }
        //    else if (numero.Length > 0 && poliza.Length == 0)
        //    {
        //        IEnumerable<Contrato> a = from d in ReadAll()
        //                                  where d.Numero == numero.ToString()
        //                                  select d;
        //        return a;
        //    }
        //    else if (numero.Length == 0 && poliza.Length > 0)
        //    {
        //        IEnumerable<Contrato> c = from d in ReadAll()
        //                                  where d.CodigoPlan == poliza.ToString()
        //                                  select d;
        //        return c;

        //    }
        //    else
        //    {
        //        return ReadAll();
        //    }

        //}

        //public IEnumerable<Contrato> ReadF(string numero)
        //{

        //    if (numero.Length > 0)
        //    {
        //        IEnumerable<Contrato> a = from d in ReadAll()
        //                                  where d.Numero == numero.ToString()
        //                                  select d;
        //        return a;
        //    }

        //    else
        //    {
        //        return ReadAll();
        //    }

        //}

        }
    }

