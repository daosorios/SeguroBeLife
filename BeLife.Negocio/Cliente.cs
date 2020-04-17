using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//holi


namespace BeLife.Negocio
{
    public class Cliente
    {
        public string RutCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string IdSexo { get; set; }
        public string IdEstadoCivil { get; set; }



        public Cliente()
        {
            this.Init();
        }
        public void Init()
        {
            RutCliente = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            FechaNacimiento = DateTime.Today;
            IdSexo = string.Empty;
            IdEstadoCivil = string.Empty;
        }

        //agregar el nuevo cliente en la base de dato y guarda los cambios de esta.
        public bool Create()
        {
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();
            Datos.Cliente cli = new Datos.Cliente();

            try
            {
                CommonBC.Syncronize(this, cli);

                cli.IdEstadoCivil = ObtenerIdCivil();
                cli.IdSexo = ObtenerIdSexo();

                bbdd.Cliente.Add(cli);
                bbdd.SaveChanges();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                bbdd.Cliente.Remove(cli);
                return false;
            }

        }

        private int ObtenerIdCivil()
        {
            //comparando la descripcion de la base de datos con la de la vista para retornar la id 
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();
            Datos.EstadoCivil estadoCivil = bbdd.EstadoCivil.First(s => s.Descripcion == IdEstadoCivil);
            int Id = estadoCivil.IdEstadoCivil;
            return Id;
        }

        private int ObtenerIdSexo()
        {
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();
            Datos.Sexo sexoDes = bbdd.Sexo.First(s => s.Descripcion == IdSexo);
            int Id = sexoDes.IdSexo;
            return Id;
        }

        //buscar en la base de dato el rut que sea igual a lo que esta ingresando
        public bool Read()
        {
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();
           
            try
            {
                Datos.Cliente cli = bbdd.Cliente.First(e => e.RutCliente == RutCliente);
                CommonBC.Syncronize(cli, this);
                //con la id sexo que viene de la base de datos obtengo la descripcion desde la bad¿se de dato para mostrarla en la vista se guarda en idsexo
                IdSexo = cli.Sexo.Descripcion;
                IdEstadoCivil = cli.EstadoCivil.Descripcion;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        //buscar el rut en la base de datos y sincronizar con los datos del cliente para guardar los cambios
        public bool Update()
        {
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();
            try
            {
                
                Datos.Cliente cli = bbdd.Cliente.First(e => e.RutCliente == RutCliente);
                CommonBC.Syncronize(this, cli);
                cli.IdEstadoCivil = ObtenerIdCivil();
                cli.IdSexo = ObtenerIdSexo();
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception )
            {

                return false;
            }
            
        }

        //busca el rut para poder eliminar al cliente y luego cambiar los cambios
        public bool Delete()
        {
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();
            
            try
            {
                Datos.Cliente cli = bbdd.Cliente.First(e => e.RutCliente == RutCliente);
                bbdd.Cliente.Remove(cli);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        //leer todos los clientes registrados en la base de datos 
        public  List<Cliente> ReadAll()
        {
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();

            try
            {
                // se crea una lista de cliente desde la base de datos
                List<Datos.Cliente> listaDatos = bbdd.Cliente.ToList<Datos.Cliente>();

                //se envia la lista de Cliente base de datos pra que retorne una lista de Cliente
                List<Cliente> listaRegistro = GenerarListado(listaDatos);

                //retrona la lista al datagrid
                return listaRegistro;
            }
            catch (Exception )
            {

                return new List<Cliente>();
            }
        }

        //
        private List<Cliente> GenerarListado(List<Datos.Cliente> listaDatos)
        {

            //se crea lista para para retornar clientes
            List<Cliente> listaRegistro = new List<Cliente>();


            //un foreach que recorre la lista de cliente de la base de datos que inserta hacia la lista de cliente
            foreach (Datos.Cliente  datos in listaDatos)

            {
                //se crea un objeto cliente
                Cliente cliente = new Cliente();
                //se envia un cliente de base de dato y un cliente y retorna un cliente nuevo
                CommonBC.Syncronize(datos, cliente);
                //le cambio el id por descripccion que me trajo el CommonBC.Syncronize(datos, cliente);
                cliente.IdSexo = datos.Sexo.Descripcion;
                cliente.IdEstadoCivil = datos.EstadoCivil.Descripcion;
                //se inserta cliente en la lista de cliente
                listaRegistro.Add(cliente);

            }

            //retorna la lista
            return listaRegistro;
        }
        public IEnumerable<Cliente> ReadSE(string rut, int idSexo, int idEstado)
        {
            if (rut.Length > 0 && idSexo > 0 && idEstado > 0)
            {
                IEnumerable<Cliente> RutySexoyEstado = from d in ReadAll()
                                                       where d.RutCliente == rut && d.IdSexo == idSexo.ToString() && d.IdEstadoCivil == idEstado.ToString()
                                                       select d;
                return RutySexoyEstado;
            }

            else if (rut.Length > 0 && idSexo > 0 && idEstado == 0)
            {
                IEnumerable<Cliente> RutySexo = from d in ReadAll()
                                                where d.RutCliente == rut && d.IdSexo == idSexo.ToString()
                                                select d;
                return RutySexo;
            }


            else if (rut.Length > 0 && idSexo == 0 && idEstado > 0)
            {
                IEnumerable<Cliente> RutyEstado = from d in ReadAll()
                                                  where d.RutCliente == rut && d.IdEstadoCivil == idEstado.ToString()
                                                  select d;
                return RutyEstado;
            }

            else if (rut.Length > 0 && idSexo == 0 && idEstado == 0)
            {
                IEnumerable<Cliente> rutt = from d in ReadAll()
                                            where d.RutCliente == rut
                                            select d;
                return rutt;
            }

            else if (idSexo > 0 && idEstado > 0)
            {
                IEnumerable<Cliente> SexoyEstado = from d in ReadAll()
                                                   where d.IdSexo == idSexo.ToString() && d.IdEstadoCivil == idEstado.ToString()
                                                   select d;
                return SexoyEstado;
            }
            else if (idSexo > 0 && idEstado == 0)
            {
                IEnumerable<Cliente> Sexo = from d in ReadAll()
                                            where d.IdSexo == idSexo.ToString()
                                            select d;
                return Sexo;
            }
            else if (idSexo == 0 && idEstado > 0)
            {
                IEnumerable<Cliente> Estado = from d in ReadAll()
                                              where d.IdEstadoCivil == idEstado.ToString()
                                              select d;
                return Estado;

            }
            else
            {
                return ReadAll();
            }

        }


    }


       
}
