using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroBeLife
{
    class Contrato
    {
        public string   Numero               { get; set; }
        public DateTime FechaCreacion        { get; set; }
        public string   RutCliente           { get; set; }
        public string   CodigoPlan           { get; set; }
        public DateTime FechaInicioVigencia  { get; set; }
        public DateTime FechaFinVigencia     { get; set; }
        public Boolean  Vigente              { get; set; }
        public Boolean  DeclaracionSalud     { get; set; }
        public float    PrimaAnual           { get; set; }
        public float    PrimaMensual         { get; set; }
        public String   Observaciones        { get; set; }

        public Contrato()
        {
            this.Init();
        }

        void Init()
        {
            Numero              =   String.Empty;
            FechaCreacion       = DateTime.Today;
            RutCliente          =   String.Empty;
            CodigoPlan          =   String.Empty;
            FechaInicioVigencia = DateTime.Today;
            FechaFinVigencia    = DateTime.Today;
            Vigente             =          false;
            DeclaracionSalud    =          false;
            PrimaAnual          =              0;
            PrimaMensual        =              0;
            Observaciones       =   String.Empty;
        }

        public bool CreateContrato()
        {
            BeLife.Datos.BeLifeEntities bbdd = new BeLife.Datos.BeLifeEntities();
            BeLife.Datos.Contrato contrato = new BeLife.Datos.Contrato();

            try
            {
                Join.Syncronize(this, contrato);

                contrato.CodigoPlan = ObtenerPlan();


                bbdd.Contrato.Add(contrato);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                bbdd.Contrato.Remove(contrato);
                return false;
                
            }          
        }
        private string ObtenerPlan()
        {
            //comparando la descripcion de la base de datos con la de la vista para retornar la id 
            BeLife.Datos.BeLifeEntities bbdd = new BeLife.Datos.BeLifeEntities();
            BeLife.Datos.Plan plan = bbdd.Plan.First(s => s.Nombre == CodigoPlan);
            string Id = plan.IdPlan;
            return Id;
        }


        //buscar en la base de datos 
        public bool ReadContrato()
        {
            BeLife.Datos.BeLifeEntities bbdd = new BeLife.Datos.BeLifeEntities();

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
    }
}
//BD
/* 
 [Numero] Nvarchar(14) NOT NULL,
 [FechaCreacion] Datetime NOT NULL,
 [RutCliente] Nvarchar(10) NOT NULL,
 [CodigoPlan] Nvarchar(5) NOT NULL,
 [FechaInicioVigencia] Datetime NOT NULL,
 [FechaFinVigencia] Datetime NOT NULL,
 [Vigente] Bit NOT NULL,
 [DeclaracionSalud] Bit NOT NULL,
 [PrimaAnual] Float NOT NULL,
 [PrimaMensual] Float NOT NULL,
 [Observaciones] Nvarchar(max) NOT NULL
 */
