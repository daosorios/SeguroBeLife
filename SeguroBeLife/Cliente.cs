using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeLife.Datos;

//BD
/*
 [RutCliente] Nvarchar(10) NOT NULL,
 [Nombres] Nvarchar(20) NOT NULL,
 [Apellidos] Nvarchar(20) NOT NULL,
 [FechaNacimiento] Datetime NOT NULL,
 [IdSexo] Int NOT NULL,
 [IdEstadoCivil] Int NOT NULL
 */

namespace SeguroBeLife
{
    class Cliente
    {
        public String RutCliente { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdSexo { get; set; }
        public int IdEstadoCivil { get; set; }

        public Cliente()
        {
            this.Init();
        }

        void Init()
        {
            RutCliente      =   String.Empty;
            Nombres         =   String.Empty;
            Apellidos       =   String.Empty;
            FechaNacimiento = DateTime.Today;
            IdSexo          =              0;
            IdEstadoCivil   =              0;
        }

        public bool Create()
        {
            BeLife.Datos.BeLifeEntities bbdd = new BeLife.Datos.BeLifeEntities();
            BeLife.Datos.Cliente cli = new BeLife.Datos.Cliente();

            try
            {
                Join.Syncronize(this, cli);
                bbdd.Cliente.Add(cli);
                bbdd.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                bbdd.Cliente.Remove(cli);
                return false;
            }

        }

        public bool Read()
        {
            BeLife.Datos.BeLifeEntities bbdd = new BeLife.Datos.BeLifeEntities();

            try
            {
                BeLife.Datos.Cliente cli = bbdd.Cliente.First(e => e.RutCliente == RutCliente);
                Join.Syncronize(cli, this);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update()
        {
            BeLife.Datos.BeLifeEntities bbdd = new BeLife.Datos.BeLifeEntities();
            try
            {

                BeLife.Datos.Cliente cli = bbdd.Cliente.First(e => e.RutCliente == RutCliente);
                Join.Syncronize(this, cli);

                bbdd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool Delete()
        {
            BeLife.Datos.BeLifeEntities bbdd = new BeLife.Datos.BeLifeEntities();

            try
            {
                BeLife.Datos.Cliente cli = bbdd.Cliente.First(e => e.RutCliente == RutCliente);
                bbdd.Cliente.Remove(cli);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Cliente> ReadAll()
        {
            BeLife.Datos.BeLifeEntities bbdd = new BeLife.Datos.BeLifeEntities();

            try
            {
                List<BeLife.Datos.Cliente> listaDatos = bbdd.Cliente.ToList<BeLife.Datos.Cliente>();

                List<Cliente> listaRegistro = GenerarListado(listaDatos);

                return listaRegistro;
            }
            catch (Exception ex)
            {

                return new List<Cliente>();
            }
        }

        private List<Cliente> GenerarListado(List<BeLife.Datos.Cliente> listaDatos)
        {
            List<Cliente> listaRegistro = new List<Cliente>();

            foreach (BeLife.Datos.Cliente datos in listaDatos)

            {
                Cliente cliente = new Cliente();
                Join.Syncronize(datos, cliente);
                listaRegistro.Add(cliente);

            }
            return listaRegistro;
        }
    }
}